using System.Security.Cryptography;
using System.Security.Policy;

namespace Tetrisz
{
    public class GameGrid
    {
        private readonly int[,] grid;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        public GameGrid(int rows, int colums) {
            Rows = rows;
            Columns = colums;
            grid = new int[Rows, Columns];
        }

        public bool IsInSIDE(int r, int c) { 
            return r >= 0 && r < Rows && c >= 0 && c < Columns;
        }

        public
    }
}
