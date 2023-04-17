using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Items
{
    public class ObjectLinkedList : IEnumerable, IList, ICollection
    {
        private int count;

        private Node first;
        private class Node
        {
            internal object Value { get; set; }
            internal Node Next { get; set; }
            internal Node Previous { get; set; }
            internal int Index { get; set; }

            public Node(object value)
            {
                Value = value;
            }

            public Node(object value, int index) : this(value)
            {
                Index = index;
            }
        }

        public ObjectLinkedList()
        {
            count = 0;
            first = null;
        }

        public object? this[int index]
        {
            get => GetValueByIndex(index);
            set => ChangeValueByIndex(index, value);

        }

        private void ChangeValueByIndex(int index, object value)
        {
            Node node = first;
            for (int i = 0; i < count; i++)
            {
                if (node.Index == index)
                {
                    node.Value = value;
                    return;
                }
                node = node.Next;
            }
        }

        private object? GetValueByIndex(int index)
        {
            Node node = first;
            for (int i = 0; i < count; i++)
            {
                if (node.Index == index) return node.Value;
                node = node.Next;
            }
            return null;
        }

        public int Count => count;

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public bool IsFixedSize => false;
        public bool IsReadOnly => false;

        public int Add(object? value)
        {
            if (value == null) return -1;

            if (count == 0)
            {
                first = new Node(value, count);
                first.Next = null;
                first.Previous = null;
                return count++;
            }
            Node last = first;
            for (int i = 1; i < count; i++) last = last.Next;

            Node node = new Node(value, count);
            node.Previous = last;
            node.Next = null;
            last.Next = node;

            return count++;
        }

        public void Clear()
        {
            first = null;
            count = 0;
        }

        public bool Contains(object? value)
        {
            IEnumerator enumerator = GetEnumerator();
            while (enumerator.MoveNext()) if (enumerator.Current == value) return true;
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            IEnumerator n = GetEnumerator();
            while (n.MoveNext()) array.SetValue(n.Current, index++);
        }

        public IEnumerator GetEnumerator()
        {
            if (first == null) return new EnumList();

            return new EnumList(first, count);
        }

        public int IndexOf(object? value)
        {
            Node node = first;
            for (int i = 0; i < count; i++)
            {
                if (node.Value == value) return node.Index;
                node = node.Next;

            }
            return -1;
        }

        public void Insert(int index, object? value)
        {
            if (index < 0 || index > count) return;
            if (index == count)
            {
                Add(value);
                return;
            }
            if (index == 0)
            {
                InsertFirst(value);
                return;
            }
            Node prev = first;
            for (int i = 1; i < index; i++) prev = prev.Next;
            Node node = new Node(value, index);
            node.Previous = prev;
            node.Next = prev.Next;
            node.Next.Previous = node;
            prev.Next = node;
            count++;
            NormalizeIndexes();
        }

        private void InsertFirst(object? value)
        {
            Node node = new Node(value, 0);
            node.Next = first;
            first.Previous = node;
            node.Previous = null;
            first = node;
            count++;
            NormalizeIndexes();
        }

        private void NormalizeIndexes()
        {
            Node node = first;
            for (int i = 0; i < count; i++)
            {
                node.Index = i;
                node = node.Next;
            }
        }

        public void Remove(object? value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || count == 0) return;
            Node prev = null;
            Node current = first;
            for (int i = 0; i < index; i++)
            {
                prev = current;
                current = current.Next;
            }
            if (current == first)
            {
                RemoveFirst();
                NormalizeIndexes();
                return;
            }
            count--;
            prev.Next = current.Next;
            if (current.Next != null)
            {
                current.Next.Previous = prev;
                NormalizeIndexes();
            }
            return;
        }

        private void RemoveFirst()
        {
            if (count == 1)
            {
                Clear();
                return;
            }
            first = first.Next;
            first.Previous = null;
            count--;
            return;
        }

        private class EnumList : IEnumerator
        {
            private int position = -1;
            private Node reset;
            private Node node;
            private int count;
            public EnumList(Node node, int count)
            {
                this.count = count;
                this.node = node;
                reset = node;
            }
            public EnumList() { }

            public bool MoveNext()
            {
                position++;
                if (position > 0) node = node.Next;
                return position < count;

            }

            public void Reset()
            {
                position = -1;
                node = reset;
            }
            object IEnumerator.Current { get => node.Value; }
        }


    }
}
