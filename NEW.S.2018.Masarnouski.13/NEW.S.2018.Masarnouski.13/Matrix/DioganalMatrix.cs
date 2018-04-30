using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Matrix
{

    public class DioganalMatrix<T> : SquareMatrix<T>
    {
        #region Constructors

        public DioganalMatrix(int size) : base(size){ }

        #endregion

        #region Properties

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

                if (!(i==j))
                {
                    throw new IndexOutOfRangeException("Values must place only on main diagonal(i must be equal to j)");
                }

                this.OnChangeValue(this, new ChangeElementEventArgs<T>(i, j, this.matrix[i, j], value));
                this.matrix[i, j] = value;
            }
        }
        #endregion
    }
}
