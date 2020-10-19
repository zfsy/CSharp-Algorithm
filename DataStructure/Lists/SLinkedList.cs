using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Collections;

namespace DataSturctures.Lists
{
    /// <summary>
    /// The Singly-Linked List Node class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SLinkedListNode<T> : IComparable<SLinkedListNode<T>> where T : IComparable<T>
    {
        private T _data;
        private SLinkedListNode<T> _next;

        public SLinkedListNode()
        {
            Next = null;
            Data = default(T);
        }

        public SLinkedListNode(T dataItem)
        {
            Next = null;
            Data = dataItem;
        }

        public T Data { get => _data; set => _data = value; }
        public SLinkedListNode<T> Next { get => _next; set => _next = value; }

        public int CompareTo([AllowNull] SLinkedListNode<T> other)
        {
            if (other == null)
            {
                return -1;
            }

            return this.Data.CompareTo(other.Data);
        }
    }

    public class SLinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private int _count;
        private SLinkedListNode<T> _firstNode { get; set; }
        private SLinkedListNode<T> _lastNode { get; set; }

        public int Count
        {
            get { return _count; }
        }

        public virtual SLinkedListNode<T> Head
        {
            get { return this._firstNode; }
        }

        public SLinkedList()
        {
            _firstNode = null;
            _lastNode = null;
            _count = 0;
        }

        public bool IsEmpty()
        {
            return (Count == 0);
        }

        public T First
        {
            get
            {
                return (_firstNode == null ? default(T) : _firstNode.Data);
            }
        }

        public T Last
        {
            get
            {
                if (Count == 0)
                {
                    throw new Exception("Empty list.");
                }

                if (_lastNode == null)
                {
                    var currentNode = _firstNode;
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    _lastNode = currentNode;
                    return currentNode.Data;
                }

                return _lastNode.Data;
            }
        }

        /// <summary>
        /// Inserts the specified dataItem at the beginning of the list.
        /// </summary>
        /// <param name="dataItem"></param>
        public void Prepend(T dataItem)
        {
            SLinkedListNode<T> newNode = new SLinkedListNode<T>(dataItem);

            if (_firstNode == null)
            {
                _firstNode = _lastNode = newNode;
            }
            else
            {
                var currentNode = _firstNode;
                newNode.Next = currentNode;
                _firstNode = newNode;
            }

            // Increment the count
            _count++;
        }

        public void Append(T dataItem)
        {
            SLinkedListNode<T> newNode = new SLinkedListNode<T>(dataItem);

            if (_firstNode == null)
            {
                _firstNode = _lastNode = newNode;
            }
            else
            {
                var currentNode = _lastNode;
                currentNode.Next = newNode;
                _lastNode = newNode;
            }

            _count++;
        }

        public void InsertAt(T dataItem, int index)
        {
            // Handle scope of insertion
            // Prepend? Append? Or Insert in the range?
            if (index == 0)
            {
                Prepend(dataItem);
            }
            else if (index == Count)
            {
                Append(dataItem);
            }
            else if (index > 0 && index < Count)
            {
                var currentNode = _firstNode;
                var newNode = new SLinkedListNode<T>(dataItem);

                for (int i = 1; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;

                _count++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Removes the item at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if (IsEmpty() || index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                _firstNode = _firstNode.Next;

                _count++;
            }
            else if (index == Count - 1)
            {
                var currentNode = _firstNode;

                while (currentNode.Next != null && currentNode.Next != _lastNode)
                    currentNode = currentNode.Next;
            }
            else
            {
                int i = 0;
                var currentNode = _firstNode;
                while (currentNode.Next != null)
                {
                    if (i + 1 == index)
                    {
                        currentNode.Next = currentNode.Next.Next;

                        _count--;
                        break;
                    }

                    ++i;
                    currentNode = currentNode.Next;
                }
            }
        }

        public void Clear()
        {
            _firstNode = null;
            _lastNode = null;
            _count = 0;
        }

        public T GetAt(int index)
        {
            if (index == 0)
            {
                return First;
            }

            if (index == (Count -1))
            {
                return Last;
            }

            if (index > 0 && index < (Count - 1))
            {
                var currentNode = _firstNode;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Data;
            }

            throw new IndexOutOfRangeException();
        }

        public SLinkedList<T> GetRange(int index, int countOfElements)
        {
            SLinkedList<T> newList = new SLinkedList<T>();
            var currentNode = this._firstNode;

            if (Count == 0)
            {
                return newList;
            }

            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            // Move the currentNode reference to the specified index
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            while (currentNode != null && newList.Count <= countOfElements)
            {
                newList.Append(currentNode.Data);
                currentNode = currentNode.Next;
            }

            return newList;
        }

        /// <summary>
        /// Sorts the entire list 
        /// </summary>
        public virtual void SelectionSort()
        {
        }

        /// <summary>
        /// Return an array version of this list
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            T[] array = new T[Count];

            var currentNode = _firstNode;
            for (int i = 0; i < Count; i++)
            {
                if (currentNode != null)
                {
                    array[i] = currentNode.Data;
                    currentNode = currentNode.Next;
                }
                else
                {
                    break;
                }
            }

            return array;
        }

        public List<T> ToList()
        {
            List<T> list = new List<T>();

            var currentNode = _firstNode;
            for (int i = 0; i < Count; i++)
            {
                if (currentNode != null)
                {
                    list.Add(currentNode.Data);
                    currentNode = currentNode.Next;
                }
                else
                {
                    break;
                }
            }

            return list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
