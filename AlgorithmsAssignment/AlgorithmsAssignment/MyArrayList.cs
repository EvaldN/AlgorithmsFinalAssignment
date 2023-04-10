using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AlgorithmsAssignment
{
    internal class MyArrayList<T> where T : IComparable<T>
    {
        private T[] _data;
        private int _count;

        public MyArrayList()
        {
            _data = new T[1000];
            _count = 0;
        }

        public int Count { get { return _count;} }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException();
                }
                return _data[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                {
                }
                _data[index] = value;
            }
        }
        public void Add(T input)
        {
            _data[_count] = input;
            _count++;
        }

        public void Remove(int index)
        {
            // shift elements to remove the entry on index
            Array.Copy(_data, index + 1, _data, index, _count - index - 1);

            _count--;
        }
        public void Clear()
        {
            _count = 0;
            _data = new T[1000];
        }
        //SORTING
        public void BubbleSort()
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < _count - 1; i++)
                {
                    if (_data[i].CompareTo(_data[i + 1]) > 0)
                    {
                        T temporaryData = _data[i];
                        _data[i] = _data[i + 1];
                        _data[i + 1] = temporaryData;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        public void SelectionSort()
        {
            for (int i = 0; i < _count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < _count; j++)
                {
                    if (_data[j].CompareTo(_data[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    T temporaryData = _data[i];
                    _data[i] = _data[minIndex];
                    _data[minIndex] = temporaryData;
                }
            }
        }
        public int LinearSearch(T value)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_data[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public int BinarySearch(T value)
        {
            BubbleSort();
            int left = 0;
            int right = _count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (_data[mid].CompareTo(value) == 0)
                {
                    return mid;
                }
                else if (_data[mid].CompareTo(value) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[ ");
            for (int i = 0; i < _count; i++)
            {
                sb.Append(_data[i].ToString());
                if (i != _count - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(" ]");

            return sb.ToString();
        }

    }
}
