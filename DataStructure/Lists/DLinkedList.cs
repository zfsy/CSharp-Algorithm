using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataSturctures.Lists
{
    public class DLinkedListNode<T> : IComparable<DLinkedListNode<T>> where T : IComparable<T>
    {
        private T _data;
        private DLinkedListNode<T> _next;
        private DLinkedListNode<T> _previous;

        public DLinkedListNode(T dataItem, DLinkedListNode<T> next, DLinkedListNode<T> previous)
        {
            Data = dataItem;
            Next = next;
            Previous = previous;
        }

        public T Data { get => _data; set => _data = value; }

        public DLinkedListNode<T> Next { get => _next; set => _next = value; }

        public DLinkedListNode<T> Previous { get => _previous; set => _previous = value; }

        public int CompareTo(DLinkedListNode<T> other)
        {
            if (other == null) return -1;

            return this.Data.CompareTo(other.Data);
        }
    }

    class DLinkedList
    {
    }
}
