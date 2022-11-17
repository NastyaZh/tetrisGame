using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using tetrisGame.Classes;
using tetrisGame.Utilities;

namespace tetrisGame.Views
{
    public partial class GameView : Form
    {
        private Game game;
        private Board board;
        private KeyCommand currentKey = KeyCommand.None;
        private int elapsedFrames;

        public GameView()
        {
            InitializeComponent();
            
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            game = new Game(Int32.Parse(SettngHeightLabel.Text) + 1, Int32.Parse(SettingWidthLabel.Text));
            game.PrepareGame();
            GameTimer_Tick(null, null);
            int sizeH = (int.Parse(SettngHeightLabel.Text) + 3) * 20; 
            int sizeW = (int.Parse(SettingWidthLabel.Text) + 2) * 20;

            MainPictureBox.ClientSize = new Size(sizeW,sizeH);
            QueuePictureBox.Location = new Point(sizeW + 30, QueuePictureBox.Location.Y);   
            this.Controls.Cast<Control>().OfType<Label>().ToList().ForEach(item =>
            {
                item.Location = new Point(sizeW + 30, item.Location.Y);
            });
        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameOver();
            var ff = IsAutoDropBlock();
            NextFrame(ff);
            RefreshView();
        }
        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            for (var i = 0; i < board.Width; i++)
            {
                for (var j = 0; j < board.Height; j++)
                {
                    if (board.Tab[j, i].Item1 != 0)
                    {
                        Drawer.DrawRectangle(e, i, j, board.Tab[j, i].Item2);
                        Drawer.DrawBox(e, i, j, Color.LightCyan);
                    }

                    DrawBoardWallsX(e, j);
                }

                DrawBoardWallsY(e, i);
            }
            DrawBoardBottomCorners(e);
        }
        

        private void NextPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Drawer.DrawBlock(e, 1, 0, game.NextBlock, 0);
        }

        
        private void GameOver()
        {
            if (game.Alive) return;
            gameTimer.Enabled = false;
            MessageBox.Show("Maybe you'll get lucky next time", "The game is over");
            Close();
        }

        private bool IsAutoDropBlock()
        {
            elapsedFrames++;
            var ff = elapsedFrames > 10;
            if (ff)
            {
                elapsedFrames = 0;
            }

            return ff;
        }

        private void NextFrame(bool ff)
        {
            board = game.Step(ff, currentKey);
        }

        private void RefreshView()
        {
            if (!game.HasChanged) return;
            MainPictureBox.Refresh();
            QueuePictureBox.Refresh();
        }


        private void GameView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    currentKey = KeyCommand.Left;
                    break;

                case Keys.Right:
                    currentKey = KeyCommand.Right;
                    break;

                case Keys.Down:
                    currentKey = KeyCommand.Down;
                    break;

                case Keys.Escape:
                    currentKey = KeyCommand.Escape;
                    break;
            }
        }

        private void GameView_KeyUp(object sender, KeyEventArgs e)
        {
            currentKey = KeyCommand.None;
        }

        private void DrawBoardBottomCorners(PaintEventArgs e)
        {
            Drawer.DrawBox(e, -1, board.Height,Color.LightGray);
            Drawer.DrawRectangle(e, -1, board.Height, Color.Gray);
            Drawer.DrawBox(e, board.Width, board.Height, Color.LightGray);
            Drawer.DrawRectangle(e, board.Width, board.Height, Color.Gray);
        }

        private void DrawBoardWallsX(PaintEventArgs e, int j)
        {
            Drawer.DrawRectangle(e, -1, j, Color.Gray);
            Drawer.DrawBox(e, -1, j, Color.LightGray);
            Drawer.DrawRectangle(e, board.Width, j, Color.Gray);
            Drawer.DrawBox(e, board.Width, j, Color.LightGray);
        }

        private void DrawBoardWallsY(PaintEventArgs e, int i)
        {
            Drawer.DrawBox(e, i, 0, Color.LightGray);
            Drawer.DrawRectangle(e, i, 0, Color.Gray);
            Drawer.DrawBox(e, i, board.Height, Color.LightGray);
            Drawer.DrawRectangle(e, i, board.Height, Color.Gray);
        }
    }
}
