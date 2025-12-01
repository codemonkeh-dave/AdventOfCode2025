using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2025
{
    public class DialHelper
    {

        private int _startingPosition;
        private int _currentPosition;
        private int _zeroPositionCount = 0;
        public DialHelper(int startingPosition = 0)
        {
            _startingPosition = startingPosition;
            _currentPosition = startingPosition;
        }

        public DialHelper L(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                _currentPosition--;
                if (_currentPosition < 0)
                {
                    _currentPosition = 99;
                }
            }

            if (_currentPosition == 0)
            {
                _zeroPositionCount++;
            }

            return this;
        }

        public DialHelper R(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                _currentPosition++;
                if (_currentPosition > 99)
                {
                    _currentPosition = 0;
                }
            }

            if (_currentPosition == 0)
            {
                _zeroPositionCount++;
            }

            return this;
        }

        public DialHelper FollowList(string list)
        {
            foreach (var item in list.Split("\r\n"))
            {
                var direction = item.Trim()[0];
                var steps = int.Parse(item.Trim().Substring(1));
                if (direction == 'L')
                {
                    L(steps);
                }
                else if (direction == 'R')
                {
                    R(steps);
                }
                else
                {
                    throw new Exception("Invalid direction");
                }
            }

            return this;
        }

        public int GetCurrentPosition()
        {
            return _currentPosition;
        }

        public int GetZeroPositionCount()
        {
            return _zeroPositionCount;
        }

    }

}
