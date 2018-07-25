using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    public struct Point
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public int Value { get; set; }
        public Point(int rowIndex, int columnIndex, int genValue)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            Value = genValue;
        }
        public void GoDown(int size)
        {
            RowIndex = RowIndex + 1;
            if (RowIndex == size - 1)
            {
                RowIndex = 1;
            }
        }
        public void GoUp(int size)
        {
            RowIndex = RowIndex - 1;
            if (RowIndex == 0)
            {
                RowIndex = size - 2;
            }
        }
        public void GoLeft(int size)
        {
            ColumnIndex = ColumnIndex - 1;
            if (ColumnIndex == 0)
            {
                ColumnIndex = size - 2;
            }
        }
        public void GoRight(int size)
        {
            ColumnIndex = ColumnIndex + 1;
            if (ColumnIndex == size - 1)
            {
                ColumnIndex = 1;
            }
        }
    }
}
