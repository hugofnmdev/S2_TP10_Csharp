using System;

namespace puzzle_game
{
    public partial class Board
    {
        private int size;
        private int width;
        private bool solved = false;
        private Tile[] board;
        
        public bool Solved => solved;

        public int Size => size;

        public int Width => width;

        public Tile[] Board1 => board;

        public Board(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size needs to be positive !");
            }
            else if (Math.Sqrt(size % 1) != 0)
            {
                throw new ArgumentException("Size needs to be a perfect square !");
            }
            this.width = Math.Sqrt(size);
            this.board
            this.solved = false;
        }

        public Board DeepCopy()
        {
            // FIXME
            throw new NotImplementedException();
        }

        public bool AreConsecutive(int []arr)
        {
            // FIXME
            throw new NotImplementedException();
        }
        
        public void Fill(int[] array)
        {
            // FIXME
            throw new NotImplementedException();
        }
        
        public void Fill()
        {
            // FIXME
            throw new NotImplementedException();
        }

    }
}
