using System;
using System.Collections.Generic;
using tetrisGame.Controller;
using tetrisGame.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace tetrisGame.Classes
{
    public class Game
    {
        public bool Alive { get; private set; } = true;
        public Board Board { get; }
        public Block CurrentBlock { get; set; }
        public Block NextBlock { get; set; }
        public bool HasChanged { get; set; }

        private readonly Random random = new Random(DateTime.Now.Millisecond);

        private readonly InputController inputController;
        private readonly List<Block> allAvailableBlocks;

        public Game(int boardHeight, int boardWidth)
        {
            Board = new Board(boardWidth, boardHeight);
            inputController = new InputController(this);
            CreateBlockController createBlockController = new CreateBlockController();
            allAvailableBlocks = createBlockController.CreateBlockList();
        }
        public Board Step(bool down, KeyCommand key)
        {
            Board.CleanBlock();
            HasChanged = false;
            PlayerInput(key);
            if (!down) return Board;

            Board.CleanBlock();
            PlayerInput(KeyCommand.Down);
            Board.CleanBlock();
            PlayerInput(KeyCommand.Down);
            return Board;
        }
        public void RestartGame()
        {
            Alive = true;
            Board.CleanAllBlock();
            PrepareGame();
        }

        public void PrepareGame()
        {
            RandomNewBlock();
            GetNextBlock();
        }

        public void GetNextBlock()
        {
            CurrentBlock = NextBlock;

            RandomNewBlock();

            CurrentBlock.RestartPosition(random.Next(Board.Width - CurrentBlock.Width));
            if (Board.IsColliding(CurrentBlock, 0, 1) || Board.CheckBoardFull())
            {
                Alive = false;
            }
        }
        private void RandomNewBlock()
        {
            NextBlock = allAvailableBlocks[random.Next(allAvailableBlocks.Count)];
        }

        private void PlayerInput(KeyCommand direction)
        {
            switch (direction)
            {
                case KeyCommand.Down:
                    inputController.DownPressCommand();
                    break;

                case KeyCommand.Left:
                    inputController.LeftPressCommand();
                    break;

                case KeyCommand.Right:
                    inputController.RightPressCommand();
                    break;

                case KeyCommand.Escape:
                    Alive = false;
                    break;

                default:
                    break;
            }
        }

    }
}
