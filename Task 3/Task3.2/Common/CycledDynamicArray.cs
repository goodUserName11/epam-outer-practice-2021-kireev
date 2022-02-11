using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CycledDynamicArray<T> : IEnumerable<T>
    {
        public DynamicArray<T> Darr;

        public CycledDynamicArray() : this(8)
        { }

        public CycledDynamicArray(int capacity)
        {
            Darr = new DynamicArray<T>(capacity);
        }

        public CycledDynamicArray(IEnumerable<T> collection)
        {
            Darr = new DynamicArray<T>(collection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(Darr.ToArray(), Darr.Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Enumerates the elements of a DynamicArray<T>
        /// </summary>
        public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
        {
            T[] _array;
            int _position;
            int _length;

            public Enumerator(T[] items, int length)
            {
                this._array = items;
                _position = 0;
                _length = length;
            }

            public T Current
            {
                get =>
                    _array[_position];
            }

            object IEnumerator.Current =>
                (object)_array[_position];

            public int Length
            {
                get => _length;

                private set
                {
                    if (value < 0)
                        throw new
                            ArgumentOutOfRangeException
                            ("value", "Cannot be negative");

                    _length = value;
                }
            }

            public bool MoveNext()
            {
                _position++;

                if (_position < Length)
                {
                    Reset();
                }

                return true;
            }

            public void Reset()
            {
                _position = 0;
            }

            public void Dispose()
            {
                //throw new NotImplementedException();
            }
        }
    }
}
