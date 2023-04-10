using AlgorithmsAssignment;
using System;
using System.Text;

class MyStack<T> where T : IComparable<T>
{
    private Node<T> _topNode;

    public bool IsEmpty()
    {
        return _topNode == null;
    }

    public void Push(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.NextNode = _topNode;
        _topNode = newNode;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new Exception("Stack underflow");
        }
        T data = _topNode.Data;
        _topNode = _topNode.NextNode;
        return data;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new Exception("Stack is empty");
        }
        return _topNode.Data;
    }
    public void Clear()
    {
        _topNode = null;
    }
    //SORTING
    public void BubbleSort()
    {
        if (IsEmpty())
        {
            return;
        }

        bool swapped = true;

        while (swapped)
        {
            swapped = false;
            Node<T> current = _topNode;
            Node<T> previous = null;

            while (current.NextNode != null)
            {
                if (current.Data.CompareTo(current.NextNode.Data) > 0)
                {
                    Node<T> temp = current.NextNode;
                    current.NextNode = temp.NextNode;
                    temp.NextNode = current;

                    if (previous == null)
                    {
                        _topNode = temp;
                    }
                    else
                    {
                        previous.NextNode = temp;
                    }

                    previous = temp;
                    swapped = true;
                }
                else
                {
                    previous = current;
                    current = current.NextNode;
                }
            }
        }
    }
    public void SelectionSort()
    {
        if (IsEmpty())
        {
            return;
        }

        Node<T> current = _topNode;

        while (current.NextNode != null)
        {
            Node<T> min = current;
            Node<T> innerCurrent = current.NextNode;

            while (innerCurrent != null)
            {
                if (innerCurrent.Data.CompareTo(min.Data) < 0)
                {
                    min = innerCurrent;
                }

                innerCurrent = innerCurrent.NextNode;
            }

            if (min != current)
            {
                T temp = current.Data;
                current.Data = min.Data;
                min.Data = temp;
            }

            current = current.NextNode;
        }
    }
    public int LinearSearch(T key)
    {
        Node<T> current = _topNode;
        int index = 0;

        while (current != null)
        {
            if (current.Data.CompareTo(key) == 0)
            {
                return index;
            }

            current = current.NextNode;
            index++;
        }

        return -1;
    }

    public int BinarySearch(T key)
    {
        BubbleSort();
        Node<T> current = _topNode;
        int size = 0;

        // Count the number of elements in the stack
        while (current != null)
        {
            current = current.NextNode;
            size++;
        }

        // Convert the stack to an array
        T[] array = new T[size];
        current = _topNode;
        int i = 0;

        while (current != null)
        {
            array[i] = current.Data;
            current = current.NextNode;
            i++;
        }

        // Perform binary search on the array
        int left = 0;
        int right = size - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (array[mid].CompareTo(key) == 0)
            {
                return mid;
            }

            if (array[mid].CompareTo(key) < 0)
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
        if (IsEmpty())
        {
            return "Stack is empty";
        }

        Node<T> current = _topNode;
        StringBuilder sb = new StringBuilder();

        while (current != null)
        {
            sb.Append(current.Data.ToString());
            sb.Append("\n");
            current = current.NextNode;
        }

        return sb.ToString();
    }

}
