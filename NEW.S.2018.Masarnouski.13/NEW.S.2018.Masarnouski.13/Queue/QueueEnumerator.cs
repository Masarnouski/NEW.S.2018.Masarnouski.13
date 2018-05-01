using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Queue
{
  
    public class QueueEnumerator<T> : IEnumerator<T>, IEnumerator
    {
        #region Private fields

        private ListQueue<T> _queue;
        private int _index;
        private T _currentElement;

        #endregion !Private fields.

        #region Сonstructors

  
        public QueueEnumerator(ListQueue<T> queue)
        {
            Queue = queue;
            _index = -1;
            _currentElement = default(T);
        }

        #endregion

        #region Properties

        private ListQueue<T> Queue
        {
            get
            {
                return _queue;
            }

            set
            {
                if (ReferenceEquals(value, null))
                {
                    throw new ArgumentNullException(nameof(Queue));
                }

                _queue = value;
            }
        }

        #endregion

        #region IEnumerator implementation

        public T Current
        {
            get
            {
                if (_index == -1)
                {
                    throw new InvalidOperationException("Enum not started.");
                }

                if (_index == -2)
                {
                    throw new InvalidOperationException("Enum ended.");
                }

                return _currentElement;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (_index == -1)
                {
                    throw new InvalidOperationException("Enum not started.");
                }

                if (_index == -2)
                {
                    throw new InvalidOperationException("Enum ended.");
                }

                return _currentElement;
            }
        }

        public void Dispose()
        {
            _index = -2;
            _currentElement = default(T);
        }

        public bool MoveNext()
        {
            if (_index == -2)
            {
                return false;
            }

            _index++;

            if (_index == _queue.Count)
            {
                _index = -2;
                _currentElement = default(T);

                return false;
            }
    
            _currentElement = _queue.GetElement(_index);

            return true;
        }

        public void Reset()
        {
            _index = -1;
            _currentElement = default(T);
        }

        #endregion
    }
}
