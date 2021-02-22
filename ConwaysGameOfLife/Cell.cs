using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    class Cell
    {
        public bool isAlive;
        public readonly List<Cell> neighbors = new List<Cell>();

        private bool isAliveNext;

        ///<summary>
        ///Determines the cells next state.
        ///</summary>
        public void CalcNewState()
        {
            // Cell alive and has <2 neighbors -> dies
            // Cell alive and has >3 neighbors -> dies
            // Cell dead and has =3 neighbors -> revived

            int aliveNeighbors = neighbors.Where(x => x.isAlive).Count();

            if (isAlive)
            {
                isAliveNext = (aliveNeighbors == 2 || aliveNeighbors == 3);
            }
            else
            {
                isAliveNext = (aliveNeighbors == 3);
            }
        }

        ///<summary>
        ///Advances Cell to the next state.
        ///</summary>
        public void Advance()
        {
            isAlive = isAliveNext;
        }
    }
}
