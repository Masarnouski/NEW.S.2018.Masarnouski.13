using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Matrix
{
        public class SymmetricMatrix<T> : SquareMatrix<T>
            where T : IComparable<T>
        {
            #region constructors

           public SymmetricMatrix(int size) : base(size) {}

            
            public SymmetricMatrix(T[,] matrix)
                : base(matrix)
            {
                if (!this.IsSymmetrical(matrix))
                {
                    throw new ArgumentException($"{matrix} must be a symmetrical matrix.");
                }
            }

            #endregion

            #region properties

            public override T this[int i, int j]
            {
                get
                {
                    if (!(i < this.Size && j < this.Size))
                    {
                        throw new IndexOutOfRangeException();
                    }

                    return this.matrix[i, j];
                }

                set
                {
                    if (!(i < this.Size && j < this.Size))
                    {
                        throw new IndexOutOfRangeException();
                    }

                    this.OnChangeValue(this, new ChangeElementEventArgs<T>(i, j, this.matrix[i, j], value));
                    this.matrix[i, j] = value;
                    base[j, i] = value;
                }
            }

            #endregion

            #region private methods

            private bool IsSymmetrical(T[,] array)
            {
                for (int i = 0; i < this.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < this.matrix.GetLength(1); j++)
                    {
                        if (array[i, j].CompareTo(array[j, i]) != 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            #endregion
        }
    }
