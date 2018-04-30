using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Matrix
{
    public class ChangeElementEventArgs<T> : EventArgs
    {
        #region fileds

        public readonly int i;
        public readonly int j;
        public readonly T OldValue;
        public readonly T NewValue;

        #endregion

        #region constructors

        public ChangeElementEventArgs(int i, int j, T oldValue, T newValue)
        {
            this.i = i;
            this.j = j;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        #endregion
    }
}
