using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Matrix
{
    class SquareMatrix<T>
    {

        protected readonly T[,] matrix;
        protected int size;


        public SquareMatrix(int size)
        {
            this.Size = size;
            this.matrix = new T[this.Size, this.Size];

        }
        public int Size
        {
            get { return this.size; }

            protected set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be greater than 0.");

                this.size = value;
            }
        }

        public SquareMatrix(T[,] matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException($"{nameof(matrix)} must be square matrix.");
            }

            this.Size = matrix.GetLength(0);
            this.matrix = matrix;
        }
    }
}