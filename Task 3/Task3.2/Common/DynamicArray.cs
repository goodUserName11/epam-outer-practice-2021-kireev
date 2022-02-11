using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable, ICloneable
    {
        int _length;
        T[] _array;

        public DynamicArray() : this(8)
        { }

        public DynamicArray(int capacity)
        {
            Capacity = capacity;

            Length = 0;
        }

        public DynamicArray(IEnumerable<T> collection) :
            this(collection.Count())
        {
            collection.ToArray().CopyTo(_array, 0);

            Length = collection.Count();
        }

        /// <summary>
        /// Number of elements contain in DynamicArray<T>
        /// </summary>
        public int Length 
        { 
            get => _length;

            private set
            {
                if (value < 0 && value <= int.MaxValue)
                    throw new
                        ArgumentOutOfRangeException
                        ("length", "Cannot be negative");

                int tempCapacity = Capacity;

                while (value > tempCapacity)
                    tempCapacity *= 2;

                Capacity = tempCapacity;

                _length = value;
            }
        }

        /// <summary>
        /// Gets or sets the total number of elements the internal
        /// data structure can hold without resizing.
        /// </summary>
        public int Capacity 
        { 
            get => _array.Length;

            set
            {
                if (value < 0 && value <= int.MaxValue)
                    throw new
                        ArgumentOutOfRangeException
                        ("capacity", "Cannot be negative");

                T[] tempArr = new T[value];

                if (_array == null)
                    _array = tempArr;
                else
                {
                    _array.CopyTo(tempArr, 0);
                    _array = tempArr;
                }
            } 
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(_array, Length);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)
                new Enumerator(_array, Length);
        }

        public object Clone()
        {
            DynamicArray<T> dynArr =
                new DynamicArray<T>(Capacity);

            dynArr.AddRange(_array);

            dynArr.Length = Length;

            return dynArr;
        }

        /// <summary>
        /// Adds an object to the end of the DynamicArray<T>
        /// </summary>
        public void Add(T item)
        {
            int cursor = Length++;

            this[cursor] = item;
        }

        /// <summary>
        /// Adds the elements of the specified collection 
        /// to the end of the DynamicArray<T>
        /// </summary>
        /// <param name="collection"></param>
        public void AddRange(IEnumerable<T> collection)
        {
            int endPosition = Length;

            Length += collection.Count();

            collection.ToArray().CopyTo(_array, endPosition);
        }

        /// <summary>
        /// Inserts an element into the DynamicArray<T> 
        /// at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Insert(int index, T item)
        {
            try
            {
                int cursor = Length;

                Length++;

                for (int i = cursor; i >= index; i--)
                {
                    this[i] = this[i-1];

                    cursor--;
                }

                this[index] = item;

                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                throw new 
                    ArgumentOutOfRangeException
                    ("Index", e.Message + e.StackTrace);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Removes the first occurrence of a specific
        /// object from the DynmicArray<T>
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (item.Equals(this[i]))
                {
                    int cursor = i;
                    for (int j = cursor+1; j < Length; j++)
                    {
                        this[cursor] = this[j];

                        cursor++;
                    }

                    Length--;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Copy elements of DynamicArray<T> to a new array
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            T[] arr = new T[Length];

            for (int i = 0; i < Length; i++)
            {
                arr[i] = this[i];
            }

            return arr;
        }

        /// <summary>
        /// Get or set element by index
        /// </summary>
        /// <param name="index">
        ///     (use negative indexes to use elements 
        ///     from the end of array)
        /// </param>
        /// <returns></returns>
        public T this[int index]
        {
            get 
            {
                if (Math.Abs(index) > Length)
                    throw 
                        new IndexOutOfRangeException
                        ("Index of DynamicArray is out of range");

                if (index >= 0)
                    return 
                        _array[index];

                return 
                    _array[Length + index];
            }

            set 
            {
                if (Math.Abs(index) > Length)
                    throw
                        new IndexOutOfRangeException
                        ("Index of DynamicArray is out of range");

                if (index >= 0)
                    _array[index] = value;
                
                else
                    _array[Length + index] = 
                        value;
            }
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
                _position = -1;
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
                return (_position < Length);
            }

            public void Reset()
            {
                _position = -1;
            }

            public void Dispose() 
            {
                //throw new NotImplementedException();
            }
        }
    }
}
