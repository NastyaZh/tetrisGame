using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace tetrisGame.Classes
{
    public class Board
    {        
        public int Height { get; set; }
        public (int, Color)[,] Tab { get; set; }
        public int Width { get; set; }



        public Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.Tab = new (int, Color)[height, width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Tab[i, j] = (0, Color.Transparent);
                }
            }
        }

        public int CheckBoard()
        {
            int counter = 0;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (Tab[i, j].Item1 != 2)
                    {
                        break;
                    }

                    counter++;
                }
                if (counter == Width)
                {
                    return i;
                }

                counter = 0;
            }
            return -1;
        }


        public bool CheckBoardFull()
        {
            int level = Height % 2 == 0 ? 1 : 2;
            for (int i = 0; i < Width; i++)
            {
                if (Tab[1, level].Item1 == 2)
                {
                    return true;
                }
            }
            return false;
        }

        public void CleanBlock()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (Tab[i, j].Item1 == 1)
                    {
                        Tab[i, j] = (0, Color.Transparent);
                    }
                }
            }
        }

        public void CleanAllBlock()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Tab[i, j] = (0, Tab[i, j].Item2);
                }
            }
        }


        public void InsertBlock(Block block)
        {
            for (int i = 0; i < block.Height; i++)
            {
                for (int j = 0; j < block.Width; j++)
                {
                    if (block.Shape[i, j].Item1 != 0)
                    {
                        Tab[block.PosY + i, block.PosX + j] = block.Shape[i, j];
                    }
                }
            }
        }

        public void PutBlock(Block block)
        {
            for (int i = 0; i < block.Height; i++)
            {
                for (int j = 0; j < block.Width; j++)
                {
                    if (block.Shape[i, j].Item1 != 0)
                    {
                        Tab[block.PosY + i, block.PosX + j] = (2, block.ColorBlock);                        
                    }
                }
            }
        }

        public bool IsColliding(Block block, int offsetX, int offsetY)
        {
            for (int i = 0; i < block.Height; i++)
            {
                for (int j = 0; j < block.Width; j++)
                {
                    if (block.Shape[i, j].Item1 != 1)
                    {
                        continue;
                    }

                    if (i + block.PosY + offsetY < 0 ||
                       i + block.PosY + offsetY >= Height ||
                       j + block.PosX + offsetX < 0 ||
                       j + block.PosX + offsetX >= Width ||
                       Tab[block.PosY + offsetY + i, block.PosX + offsetX + j].Item1 == 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public void Gravitate(int multiplier = 10)
        {
            int level = CheckBoard();
            while (level != -1)
            {
                MoveDown(level);
                level = CheckBoard();
                multiplier++;
            }
        }

        private void MoveDown(int level)
        {
            for (int i = level - 1; i >= 0; i--)
            {
                for (int j = 0; j < Width; j++)
                {
                    Tab[i + 1, j] = Tab[i, j];
                }
            }
        }
    }
}
