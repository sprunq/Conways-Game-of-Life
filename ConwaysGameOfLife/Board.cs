using System;

namespace GameOfLife
{
    class Board
    {
        public Cell[,] Cells;
        public int CellSize;
        private readonly Random rand = new Random();

        public int Columns { get { return Cells.GetLength(0); } }
        public int Rows { get { return Cells.GetLength(1); } }
        public int Width { get { return Columns * CellSize; } }
        public int Height { get { return Rows * CellSize; } }

        public Board(int width, int height, int cellSize, bool wrap = false)
        {
            CellSize = cellSize;
            Cells = new Cell[width / cellSize, height / cellSize];
            for(int x = 0; x < Columns; x++)
            {
               for(int y = 0; y < Rows; y++)
                {
                    Cells[x, y] = new Cell();
                }
            }
            GetNeighbors(wrap);
        }

        ///<summary>
        ///Advances to the next game step.
        ///</summary>
        public void NextStep()
        {
            foreach(var cell in Cells)
            {
                cell.CalcNewState();
            }
            foreach(var cell in Cells)
            {
                cell.Advance();
            }
        }

        ///<summary>
        ///Fills the board with a random pattern.
        ///</summary>
        public void RandomPattern()
        {
            foreach (var cell in Cells)
                cell.isAlive = rand.Next(0, 2) == 0;
        }

        ///<summary>
        ///Kills all cells.
        ///</summary>
        public void Genocide()
        {
            foreach (var cell in Cells)
                cell.isAlive = false;
        }

        ///<summary>
        ///Returns the amount of cells which are currently alive.
        ///</summary>
        public int AliveCells()
        {
            int aliveCells = 0;
            foreach (var cell in Cells)
                if (cell.isAlive)
                    aliveCells++;
            return aliveCells;

        }

        ///<summary>
        ///Attaches all surrounding neighbors to a cell.
        ///</summary>
        private void GetNeighbors(bool wrap)
        {
            for(int x = 0; x < Columns; x++)
            {
                for(int y = 0; y < Rows; y++)
                {
                    // Left Edge, Right Edge, Top Edge, Bottom Edge
                    bool isEdge = (x == 0) | (x == Columns - 1) | (y == 0) | (y == Rows - 1);

                    if ((wrap == false) && isEdge)
                        continue;

                    // determine the left and right cells with wrapping
                    int xLeft = (x > 0) ? x - 1 : Columns - 1;
                    int xRight = (x < Columns - 1) ? x + 1 : 0;

                    // determine the bottom and top cells with wrapping
                    int xTop = (y > 0) ? y - 1 : Rows - 1;
                    int xBottom = (y < Rows - 1) ? y + 1 : 0;

                    // add the 8 neighbors surrounding this cell
                    // o - -
                    // - x -
                    // - - -
                    // starting at o and rotating clockwise
                    Cells[x, y].neighbors.Add(Cells[xLeft, xTop]); 
                    Cells[x, y].neighbors.Add(Cells[x, xTop]);
                    Cells[x, y].neighbors.Add(Cells[xRight, xTop]);
                    Cells[x, y].neighbors.Add(Cells[xRight, y]);
                    Cells[x, y].neighbors.Add(Cells[xRight, xBottom]);
                    Cells[x, y].neighbors.Add(Cells[x, xBottom]);
                    Cells[x, y].neighbors.Add(Cells[xLeft, y]);
                    Cells[x, y].neighbors.Add(Cells[xLeft, xBottom]);
                }
            }
        }
    }
}
