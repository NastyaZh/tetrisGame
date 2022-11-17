using System;
using System.Drawing;

namespace tetrisGame.Classes
{
    public class Block
    {
        public int Height => Shape.GetLength(0);
        public int Width => Shape.GetLength(1);
        public Color ColorBlock { get; private set; }
        public int PosX { get; protected set; }
        public int PosY { get; protected set; }

        public (int, Color)[,] Shape { get; set; }

        public Block(int sizeX = 1, int sizeY = 1, int posX = 0, int posY = 0)
        {
            Shape = new ValueTuple<int, Color>[sizeX, sizeY];
            this.PosX = posX;
            this.PosY = posY;
            ColorBlock = Color.LightBlue;

        }

        private void Move(int offsetX, int offsetY)
        {
            PosX += offsetX;
            PosY += offsetY;
        }

        public void RestartPosition(int newPosX)
        {
            PosY = 0;
            PosX = newPosX;
        }

        public void MoveDown()
        {
            Move(0, 1);
        }

        public void MoveLeft()
        {
            Move(-1, 0);
        }

        public void MoveRight()
        {
            Move(1, 0);
        }

    }
}
