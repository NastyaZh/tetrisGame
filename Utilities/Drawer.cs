using System.Drawing;
using System.Windows.Forms;
using tetrisGame.Classes;

namespace tetrisGame.Utilities
{
    public static class Drawer
    {
        private const int BoxHeight = 10;
        private const int BoxMarginHorizontal = 10;
        private const int BoxMarginVertical = 10;
        private const int BoxWidth = 10;
        private const int ScaleFactor = 2;
        private static readonly Pen Pen = new Pen(new SolidBrush(Color.White), 2);

        public static void DrawBox(PaintEventArgs e, int x, int y, Color color)
        {

            var lighterColor = color;

            var darkerColor = Color.DarkGray;

            var startingX = (x + 1) * BoxMarginHorizontal * ScaleFactor;
            var startingY = y * BoxMarginVertical * ScaleFactor;

            var oldPenColor = Pen.Color;

            Pen.Color = lighterColor;
            DrawUpperLine(e, startingX, startingY);

            DrawLeftLine(e, startingX, startingY);

            Pen.Color = darkerColor;
            DrawRightLine(e, startingX, startingY);

            DrawBottomLine(e, startingX, startingY);

            Pen.Color = oldPenColor;
        }

        public static void DrawBlock(PaintEventArgs e, int blockNumber, int posY, Block block, int offset)
        {
            for (var i = 0; i < block.Width; i++)
            {
                for (var j = 0; j < block.Height; j++)
                {
                    if (block.Shape[j,i].Item1 == 0) continue;
                    DrawRectangle(e, i, j + offset + 2 * blockNumber, Color.LightBlue);
                    DrawBox(e, i, j + offset + 2 * blockNumber, Color.LightCyan);
                }
            }
        }

        public static void DrawRectangle(PaintEventArgs e, int x, int y, Color color)
        {
            var brush = new SolidBrush(color);
            e.Graphics.FillRectangle(brush, (x + 1) * BoxMarginHorizontal * ScaleFactor, y * BoxMarginVertical * ScaleFactor, BoxWidth * ScaleFactor, BoxHeight * ScaleFactor);
        }

        private static void DrawBottomLine(PaintEventArgs e, int startingX, int startingY)
        {
            e.Graphics.DrawLine(Pen, startingX, startingY + BoxHeight * ScaleFactor, startingX + BoxWidth * ScaleFactor,
                startingY + BoxHeight * ScaleFactor);
        }

        private static void DrawLeftLine(PaintEventArgs e, int startingX, int startingY)
        {
            e.Graphics.DrawLine(Pen, startingX, startingY, startingX, startingY + BoxHeight * ScaleFactor);
        }

        private static void DrawRightLine(PaintEventArgs e, int startingX, int startingY)
        {
            e.Graphics.DrawLine(Pen, startingX + BoxWidth * ScaleFactor, startingY, startingX + BoxWidth * ScaleFactor,
                startingY + BoxHeight * ScaleFactor);
        }

        private static void DrawUpperLine(PaintEventArgs e, int startingX, int startingY)
        {
            e.Graphics.DrawLine(Pen, startingX, startingY, startingX + BoxWidth * ScaleFactor, startingY);
        }
    }
}
