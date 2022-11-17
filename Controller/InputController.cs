using tetrisGame.Classes;

namespace tetrisGame.Controller
{
    public class InputController
    {
        private readonly Game game;

        public InputController(Game game)
        {
            this.game = game;
        }

        public void LeftPressCommand()
        {
            if (game.Board.IsColliding(game.CurrentBlock, -1, 0))
            {
                return;
            }

            game.HasChanged = true;
            game.CurrentBlock.MoveLeft();
            game.Board.InsertBlock(game.CurrentBlock);
        }

        public void RightPressCommand()
        {
            if (game.Board.IsColliding(game.CurrentBlock, 1, 0))
            {
                return;
            }

            game.HasChanged = true;
            game.CurrentBlock.MoveRight();
            game.Board.InsertBlock(game.CurrentBlock);
        }

        public void DownPressCommand()
        {
            if (game.Board.IsColliding(game.CurrentBlock, 0, 1))
            {
                game.Board.PutBlock(game.CurrentBlock);
                game.Board.Gravitate(game.Board.Width);
                game.GetNextBlock();
                return;
            }

            game.HasChanged = true;
            game.CurrentBlock.MoveDown();
            game.Board.InsertBlock(game.CurrentBlock);
            
        }
    }
}
