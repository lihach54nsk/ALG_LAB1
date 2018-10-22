using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListApp
{
    class LinkedList1<T> : IList<T> where T : IComparable<T>
    {
        class LinkedListNode1
        {
            public LinkedListNode1 Next { get; set; }

            public T Value { get; set; }

            public LinkedListNode1(T value, LinkedListNode1 next)
            {
                Value = value;
                Next = next;
            }
        }

        private LinkedListNode1 _head;

        public T Head { get => _head.Value; }

        public T Tail { get => this[Count - 1]; }

        public T this[int index]
        {
            get => GetNode(index).Value;
            set => GetNode(index).Value = value;
        }

        public int Count { get; private set; } = 0;

        public bool IsEmpty => Count == 0;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            _head = new LinkedListNode1(item, _head);
            Count++;
        }

        public void AddWithSort(T item)
        {
            var last = _head;

            if (_head == null || _head.Value.CompareTo(item) > 0)
            {
                Add(item);
                return;
            }

            for (int i = 1; i < Count; i++)
            {
                var current = last.Next;
                if (current.Value.CompareTo(item) > 0)
                {
                    last.Next = new LinkedListNode1(item, current);
                    Count++;
                    return;
                }
                last = last.Next;
            }
            Count++;
            last.Next = new LinkedListNode1(item, last.Next);
        }

        public void Clear()
        {
            _head = null;
            Count = 0;
        }

        public bool Contains(T item) => (IndexOf(item) >= 0);

        public void CopyTo(T[] array, int arrayIndex)
        {
            var length = array.Length;

            if (arrayIndex >= length)
                throw new IndexOutOfRangeException();

            for (int i = 0; i < length; i++)
                Add(array[i]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = _head;
            for (int i = 0; i < Count; i++)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        public int IndexOf(T item)
        {
            var current = _head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Value.CompareTo(item) == 0)
                    return i;
                current = current.Next;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index == 0)
            {
                Add(item);
                return;
            }

            var node = GetNode(index - 1);

            node.Next = new LinkedListNode1(item, node.Next);

            Count++;
        }

        public bool Remove(T item)
        {
            var lastItem = _head;
            if (lastItem.Value.CompareTo(item) == 0)
            {
                _head = _head.Next;
                Count--;
                return true;
            }
            for (int i = 1; i < Count; i++)
            {
                var currentItem = lastItem.Next;
                if (currentItem.Value.CompareTo(item) == 0)
                {
                    lastItem.Next = currentItem.Next;
                    Count--;
                    return true;
                }
                lastItem = currentItem;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count) throw new IndexOutOfRangeException();
            if (index == 0)
            {
                _head = _head.Next;
                Count--;
                return;
            }
            var node = GetNode(index - 1);
            node.Next = node.Next.Next;
            Count--;
        }

        private LinkedListNode1 GetNode(int index)
        {
            var currentNode = _head;

            if (index >= Count) throw new IndexOutOfRangeException();

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in this)
            {
                sb.Append($"{item} ");
            }
            return sb.ToString();
        }
    }
}