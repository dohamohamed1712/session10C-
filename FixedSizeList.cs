using System;
using System.Collections.Generic;
using System.Text;

namespace session10C_
{
    
        internal class FixedSizeList<T>
        {
            private T[] _items;
            private int _count;
            private int _capacity;

            public FixedSizeList(int capacity)
            {
                _capacity = capacity;
                _items = new T[capacity];
                _count = 0;
            }

            public void Add(T item)
            {
                if (_count >= _capacity)
                    throw new InvalidOperationException("The list is full. Cannot add more elements. Capacity = " + _capacity);

                _items[_count] = item;
                _count++;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException("Invalid index: " + index + ". Valid range is 0 to " + (_count - 1) + ".");

                return _items[index];
            }

            public int Count => _count;
            public int Capacity => _capacity;
        }
    }


