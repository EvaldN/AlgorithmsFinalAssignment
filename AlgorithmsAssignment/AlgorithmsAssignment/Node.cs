using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmsAssignment
{
    internal class Node<T>
    {
        private T _data;
        private Node<T>  _nextNode;

        public Node(T data)
        {
            this._data = data;
            this._nextNode = null;
        }

        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node<T> NextNode
        {
            get { return _nextNode; }
            set { _nextNode = value; }
        }
    }
}
