using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._13.Queue
{

    public class ListQueue<T>: IEnumerable<T>
    {
        #region private fields

        private List<T> container;
        private int head = 0;
        private int tail = -1;
        private int capacity = 1;

        #endregion

        #region constructors

        public ListQueue()
            : this(1)
        {}


        public ListQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(capacity)} must be greater than 0");
            }

            this.container = new List<T>(capacity);
            this.capacity = capacity;
        }

        public ListQueue(IEnumerable<T> sequence)
        {
            if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence));
            }

            this.container = sequence.ToList();
            tail = Count - 1;
        }

        #endregion

        #region Properties

        public int Count
        {
            get { return this.container.Count; }
        }

        public bool IsEmpty => this.Count == 0;

        #endregion

        #region Public methods

        public void Enqueue(T obj)
        {
            container.Add(obj);
            tail++;
        }

       
        public T Dequeue()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            if (this.head > this.Count - 1)
            {
                this.head = 0;
            }

            T result = container[head];
            container.Remove(container[head]);
            tail--;
            return result;
        }

        public void Clear()
        {
            this.container = new List<T>(this.capacity);
            this.tail = -1;
            this.head = 0;
        }

        public T Peek()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            return this.container[this.head];
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        public T GetElement(int index)
        {
            if (index < 0 || index >= this.Count)
                throw new ArgumentException($" Incorrect {nameof(index)}");
            return container[index];
        }
        #endregion


    }
}
