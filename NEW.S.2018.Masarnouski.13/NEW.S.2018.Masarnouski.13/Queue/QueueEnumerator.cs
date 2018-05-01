using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Queue
{
    /// <summary>
    /// Provides a custom queue enumerator.
    /// </summary>
    /// <typeparam name="T">Type of the queue elements.</typeparam>
    public class QueueEnumerator<T> : IEnumerator<T>, IEnumerator
    {
        #region Private fields

        private ListQueue<T> _queue;
        private int _index;
        private T _currentElement;

        #endregion !Private fields.

        #region Public constructors

        /// <summary>
        /// Initializes an instance of the <see cref="QueueEnumerator{T}"/> with the passed queue.
        /// </summary>
        /// <param name="queue">A queue for enumerate.</param>
        public QueueEnumerator(ListQueue<T> queue)
        {
            Queue = queue;
            _index = -1;
            _currentElement = default(T);
        }

        #endregion !Public constructors.

        #region Private properties

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

        #endregion !Private properties.ss

        #region IEnumerator implementation

        /// <summary>
        /// The current element in the queue.
        /// </summary>
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

        /// <summary>
        /// The current element in the queue.
        /// </summary>
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

        /// <summary>
        /// Releases resources of the enumerator.
        /// </summary>
        public void Dispose()
        {
            _index = -2;
            _currentElement = default(T);
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>true if enum started or not ended yet, false otherwise.</returns>
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

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection.
        /// </summary>
        public void Reset()
        {
            _index = -1;
            _currentElement = default(T);
        }

        #endregion !IEnumerator implementation.
    }
}
