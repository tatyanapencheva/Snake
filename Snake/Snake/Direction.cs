using System;
using System.Collections.Generic;

namespace Snake
{
    public class Direction
    {
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);

        public int RowOfset { get;  }
        public int ColOfset { get;  }

        private Direction(int rowOfSet, int colOfSet)
        {
            RowOfset = rowOfSet;
            ColOfset = colOfSet;
        }

        public Direction Opposite ()
        {
            return new Direction(-RowOfset, -ColOfset); 
        }

        public override bool Equals(object obj)
        {
            return obj is Direction diraction &&
                   RowOfset == diraction.RowOfset &&
                   ColOfset == diraction.ColOfset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(-RowOfset, -ColOfset);
        }

        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}
