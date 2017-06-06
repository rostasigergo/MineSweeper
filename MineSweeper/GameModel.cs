using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class GameModel
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int MinesCount { get; private set; }
        private readonly int[,] Map;

        public GameModel(int rows, int columns, int minescount)
        {
            if (rows <= 0) throw new ArgumentOutOfRangeException("Number of rows must be greater than zero!");
            if (columns <= 0) throw new ArgumentOutOfRangeException("Number of columns must be greater than zero!");
            Rows = rows;
            Columns = columns;
            Map = new int[rows, columns];

            //Todo...
        }

        public bool isMine(int i,int k)
        {
            if (i >= 0 && i < Columns && k >= 0 && k < Rows)
            {
                if (Map[k, i] == Field.MINE) return true;
                else return false;
            }
            else return false;
        }
        public bool isEmpty(int i, int k)
        {
            if (i >= 0 && i < Columns && k >= 0 && k < Rows)
            {
                if (Map[k, i] == Field.EMPTY) return true;
                else return false;
            }
            else return false;
        }

    }
    public static class Field
    {
        public const int MINE = -1;
        public const int EMPTY = 0;
    }
}
