using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Matrix
{
    public static class Operations
    {
        public static SquareMatrix<T> Multiply<T>(this SquareMatrix<T> firstMatrix, SquareMatrix<T> secondMatrix)
        {
            if (firstMatrix is null)
            {
                throw new ArgumentNullException();
            }

            if (secondMatrix is null)
            {
                throw new ArgumentNullException();
            }

            if (firstMatrix.Size != secondMatrix.Size)
            {
                throw new ArgumentException("matrix must be the same size.");
            }

            SquareMatrix<T> newMatrix = new SquareMatrix<T>(firstMatrix.Size);

            for (int i = 0; i < secondMatrix.Size; i++)
            {
                for (int j = 0; j < secondMatrix.Size; j++)
                {
                    newMatrix[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                }
            }

            return newMatrix;
        }
    }
}
