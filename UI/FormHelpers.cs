using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.UI
{
    public static class FormHelpers
    {
        public static List<Point> CalculateCardPositions(Size canvas, Size item, int spacing)
        {
            var positions = new List<Point>();

            Size available = new(canvas.Width - (2 * spacing), canvas.Height - (2 * spacing));

            int columns = (available.Width + spacing) / (item.Width + spacing);
            int rows = (available.Height + spacing) / (item.Height + spacing);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    int x = spacing + col * (item.Width + spacing);
                    int y = spacing + row * (item.Height + spacing);

                    if (x + item.Width <= canvas.Width && y + item.Height <= canvas.Height)
                    {
                        positions.Add(new Point(x, y));
                    }
                }
            }

            return positions;
        }

        public static List<Point> CalculateFlexSpaceAround(Size canvas, Size item, int cardCount)
        {
            List<Point> positions = [];

            int columns = (int)Math.Sqrt(cardCount);
            int rows = (int)Math.Ceiling((double)cardCount / columns);

            int totalCardWidth = columns * item.Width;
            int totalHorizontalSpacing = canvas.Width - totalCardWidth;
            int horizontalGap = totalHorizontalSpacing / (columns + 1);
            int remainingHorizontalSpace = totalHorizontalSpacing % (columns + 1);

            int totalCardHeight = rows * item.Height;
            int totalVerticalSpacing = canvas.Height - totalCardHeight;
            int verticalGap = totalVerticalSpacing / (rows + 1);
            int remainingVerticalSpace = totalVerticalSpacing % (rows + 1);

            int cardIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (cardIndex >= cardCount)
                        break;

                    int x = horizontalGap + col * (item.Width + horizontalGap) + (col < remainingHorizontalSpace ? 1 : 0);
                    int y = verticalGap + row * (item.Height + verticalGap) + (row < remainingVerticalSpace ? 1 : 0);

                    positions.Add(new Point(x, y));
                    cardIndex++;
                }
            }

            return positions;
        }

        public static string[] SplitIntoChunks(string str, int chunkSize)
        {
            int length = (str.Length + chunkSize - 1) / chunkSize;
            string[] chunks = new string[length];

            for (int i = 0; i < length; i++)
            {
                int start = i * chunkSize;
                chunks[i] = str.Substring(start, Math.Min(chunkSize, str.Length - start));
            }

            return chunks;
        }

        public static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        public static List<int> CalculateVerticalListPositions(Size item, int gap, int itemCount)
        {
            List<int> positions = [];

            for (int i = 0; i < itemCount; i++)
            {
                int y = i * (item.Height + gap);
                positions.Add(y);
            }

            return positions;
        }
    }
}
