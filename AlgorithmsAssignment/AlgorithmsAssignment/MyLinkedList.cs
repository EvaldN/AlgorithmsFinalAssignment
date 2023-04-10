using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmsAssignment
{
    internal class MyLinkedList<T> where T : IComparable<T>
    {
        private Node<T> _headNode;

        public MyLinkedList() { }

        public Node<T> HeadNode
        {
            get { return _headNode; }
            set { _headNode = value; }
        }
        public void Add(T data)
        {
            Node<T> addedNode = new Node<T>(data);
            if (_headNode == null)
            {
                _headNode = addedNode;
            }
            else
            {
                Node<T> currentNode = _headNode;

                while(currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode; ;
                }

                currentNode.NextNode = addedNode;
            }
        }
        public void Remove(int index) 
        {
            if(_headNode == null)
            {
                return;
            }
            if(index == 0)
            {
                _headNode = _headNode.NextNode;
                return;
            }

            Node<T> currentNode = _headNode;
            Node<T> previousNode = null;
            int i = 0;
            while (currentNode != null && i < index)
            {
                previousNode = currentNode;
                currentNode= currentNode.NextNode;
                i++;
            }

            if(currentNode == null)
            {
                return;
            }
            else
            {
                previousNode.NextNode = currentNode.NextNode;
            }
        }
        public Node<T> GetNode(int index)
        {
            if(_headNode == null)
            {
                return null;
            }

            Node<T> currentNode = _headNode;
            int i = 0;

            while(currentNode != null && i < index)
            {
                currentNode = currentNode.NextNode;
                i++;
            }

            if(currentNode == null)
            {
                return null;
            }
            return currentNode;
        }
        public void Clear()
        {
            _headNode = null;
        }
        //SORTING
        public void BubbleSort()
        {
            if (_headNode == null || _headNode.NextNode == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node<T> current = _headNode;
                Node<T> previous = null;

                while (current.NextNode != null)
                {
                    if (current.Data.CompareTo(current.NextNode.Data) > 0)
                    {
                        Node<T> next = current.NextNode;

                        current.NextNode = next.NextNode;
                        next.NextNode = current;

                        if (previous == null)
                        {
                            _headNode = next;
                        }
                        else
                        {
                            previous.NextNode = next;
                        }

                        previous = next;
                        swapped = true;
                    }
                    else
                    {
                        previous = current;
                        current = current.NextNode;
                    }
                }
            } while (swapped);
        }
        public void SelectionSort()
        {
            if (_headNode == null || _headNode.NextNode == null)
                return;

            Node<T> current = _headNode;

            while (current != null)
            {
                Node<T> minNode = current;
                Node<T> innerCurrent = current.NextNode;

                while (innerCurrent != null)
                {
                    if (innerCurrent.Data.CompareTo(minNode.Data) < 0)
                    {
                        minNode = innerCurrent;
                    }

                    innerCurrent = innerCurrent.NextNode;
                }

                if (minNode != current)
                {
                    // Swap the data of current and minNode
                    T temp = current.Data;
                    current.Data = minNode.Data;
                    minNode.Data = temp;
                }

                current = current.NextNode;
            }
        }
        public int LinearSearch(T value)
        {

            Node<T> current = _headNode;
            int index = 0;

            while (current != null)
            {
                if (current.Data.CompareTo(value) == 0)
                {
                    return index;
                }

                current = current.NextNode;
                index++;
            }

            return -1;
        }

        public int BinarySearch(T value)
        {
            BubbleSort();
            int left = 0;
            int right = GetLength() - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                T midValue = GetNode(mid).Data;

                if (midValue.CompareTo(value) == 0)
                {
                    return mid;
                }
                else if (midValue.CompareTo(value) < 0)
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

        private int GetLength()
        {
            int length = 0;
            Node<T> current = _headNode;

            while (current != null)
            {
                length++;
                current = current.NextNode;
            }

            return length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> current = _headNode;
            while (current != null)
            {
                sb.AppendFormat("{0}", current.Data.ToString()) ;
                sb.Append("\n");
                current = current.NextNode;
            }
            return sb.ToString();
        }
    }
}
