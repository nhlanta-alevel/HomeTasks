using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    public struct MyWorld
    {
        private Display _display;
        private Area _area;
        private Point _cursorPoint;
        private Point _genPoint;
        private Random _rd;

        public MyWorld(int size)
        {
            _rd = new Random();
            _display = new Display();
            _area = new Area(size);
            _cursorPoint = new Point(2, 1, 0);
            _genPoint = GeneratePoint(_rd, _area.Size);

        }

        private static Point GeneratePoint(Random rd, int size)
        {
            return new Point(rd.Next(1, size - 2), rd.Next(1, size - 2), rd.Next(1, 9));
        }
        private void ResolveCollision()
        {
            if (_cursorPoint.RowIndex == _genPoint.RowIndex && _cursorPoint.ColumnIndex == _genPoint.ColumnIndex)
            {
                _cursorPoint.Value = _cursorPoint.Value + _genPoint.Value;
                if(_cursorPoint.Value > 9)
                {
                    _cursorPoint.Value = _cursorPoint.Value - 10;
                }
                _genPoint = GeneratePoint(_rd, _area.Size);
            }
        }

        public void Draw()
        {
            _display.Draw(_area, _cursorPoint, _genPoint);
        }
        public void GoDown()
        {
            _cursorPoint.GoDown(_area.Size);
            ResolveCollision();
            _display.Draw(_area, _cursorPoint, _genPoint);

        }
        public void GoUp()
        {
            _cursorPoint.GoUp(_area.Size);
            ResolveCollision();
            _display.Draw(_area, _cursorPoint, _genPoint);

        }
        public void GoRight()
        {
            _cursorPoint.GoRight(_area.Size);
            ResolveCollision();
            _display.Draw(_area, _cursorPoint, _genPoint);

        }
        public void GoLeft()
        {
            _cursorPoint.GoLeft(_area.Size);
            ResolveCollision();
            _display.Draw(_area, _cursorPoint, _genPoint);

        }


    }
}
