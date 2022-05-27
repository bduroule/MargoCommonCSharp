using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmAndDataStruct
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public MyLinkedList() {}
        public MyLinkedList(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new NullReferenceException("the colection is null");
            foreach (var elem in collection) {
                AddLast(elem);
            }
        }
        MyLinkedListNode<T> Head;

        public int Count { get;  private set; }
        public MyLinkedListNode<T>  First { get {return Head; } }
       //  public MyLinkedListNode<T>  Last { get { GetLastElem(); } }

        protected MyLinkedListNode<T> CreatElem(T item, MyLinkedListNode<T> next)
        {
            MyLinkedListNode<T> elem = new MyLinkedListNode<T>();
            elem.item = item;
            elem.next = next;
            return elem;
        }
        public MyLinkedListNode<T> GetLastElem()
        {
            MyLinkedListNode<T> _head = Head;

            while (_head.next != null) {
                _head = _head.next;
            }
            return _head;
        }

        public void Visit(Action<T> function)
        {
            MyLinkedListNode<T> _head = Head;

             while (_head.next != null) {
                function(_head.item);
                _head = _head.next;
            }
        }

        public void AddLast(T item)
        {
            Console.WriteLine($"test add {item}");
            if (Head == null) {
                Head = CreatElem(item, null);
            }
            else {
                MyLinkedListNode<T> _head = Head;

                while (_head.next != null) {
                    _head = _head.next;
                }
                _head.next = CreatElem(item, null);
            }
            Count++;
        }

        private void InitEmptyList(T item)
        {
            Head = CreatElem(item, null);
        }
    
        private bool IsEmpty => Head == null;


        public void Add(T item) { AddLast(item); }
        public void AddFirst(T item)
        {
            if (IsEmpty) {
                InitEmptyList(item);
            }
            else {
                MyLinkedListNode<T> _head = Head;
                Head = CreatElem(item, _head); // Head = CreatElem(item, GetLastElem(), _head);
            }
            Count++;
        }

        // TODO methode parcourire reverse + use Last
        public void PrintList()
        {
            MyLinkedListNode<T> _head = Head;
            while (_head != null) {
                if (_head.next == null)
                    Console.Write($"{_head}");
                else
                    Console.Write($"{_head.item}->");
                _head = _head.next;
            }
            Console.WriteLine();
        }

        public void RemoveFirst()
        {
            if (Head == null)
                throw new NullReferenceException("the list is null");
            if (Head.next == null)
                Head = null;
            else {
                MyLinkedListNode<T> _head = Head;
                _head = Head.next;
                Head = null;
                Head = _head;
            }
            Count++;
        }

        public void RemoveLast()
        {
            if (Head == null)
                throw new NullReferenceException("the list is null");
            if (Head.next == null)
                Head = null;
            else {
                MyLinkedListNode<T> lastElem = GetLastElem().previus;
                // lastElem.next = null;
                Console.WriteLine($"last :: {lastElem.item}");
                lastElem.next = null;
            }
        }

        public void ReversList()
        {
            MyLinkedListNode<T> prev = null;
            MyLinkedListNode<T> cur = Head;
            MyLinkedListNode<T> tmp;

            while(cur != null) {
                tmp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = tmp;
            }
            Head = prev;
        }

        public MyLinkedListNode<T> SortMiddleList()
        {
            MyLinkedListNode<T> TmpList = Head;
            Console.WriteLine($"count {Count / 2}");

            for (int i = 0; i < Count / 2; i++) {
                Console.WriteLine($"mid == {TmpList.item}");
                TmpList = TmpList.next;
            }
            Console.WriteLine($"mid == {TmpList.item}");
            return TmpList;
        }

        public void Remove(T item)
        {
            MyLinkedListNode<T> tmpListToRemove = Head;

            while (tmpListToRemove.next != null) {
                if (tmpListToRemove.next.item.Equals(item)) {
                    break ;
                }
                tmpListToRemove = tmpListToRemove.next;
            }
            if (tmpListToRemove.next != null)
                tmpListToRemove.next = tmpListToRemove.next.next;
            else
                RemoveLast();
        }

        public LinkedListEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(Head);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}


