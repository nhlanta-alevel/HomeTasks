using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    public struct Display
    {
        public void Draw(Area area, Point cursorPoint, Point genPoint)
        {
            string[,] strArray = StoreArray(area, cursorPoint, genPoint);
            DisplayArray(strArray, area.Size);
        }
        private static string[,] StoreArray(Area area, Point cursorPoint, Point genPoint)
        {
            string[,] strArr = new string[area.Size, area.Size];

            for (int line = 0; line < area.Size; line++)
            {
                for (int row = 0; row < area.Size; row++)
                {
                    if (line == 0 || line == area.Size - 1 || row == 0 || row == area.Size - 1)
                    {
                        strArr[line, row] = ". ";
                    }
                    else if (row == cursorPoint.ColumnIndex && line == cursorPoint.RowIndex)
                    {
                        strArr[line, row] = cursorPoint.Value.ToString() + " ";
                    }
                    else if (row == genPoint.ColumnIndex && line == genPoint.RowIndex)
                    {
                        strArr[line, row] = genPoint.Value.ToString() + " ";
                    }
                    else
                    {
                        strArr[line, row] = "  ";
                    }
                }
            }
            return strArr;
        }

        private static void DisplayArray(string[,] strArr, int size)
        {
            Console.Clear();
            for (int line = 0; line < size; line++)
            {
                for (int row = 0; row < size; row++)
                {
                    Console.Write(strArr[line, row]);
                }
                Console.WriteLine();
            }
        }

    }
}
