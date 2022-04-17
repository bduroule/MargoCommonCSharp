namespace AlgorithmAndDataStruct
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        public MyLinkedListNode<T> _linkedList;

        public LinkedListEnumerator(MyLinkedListNode<T> list)
        {
            _linkedList = list;
        }

        public bool MoveNext()
        {
            if (_linkedList.next == null)
                return false;
            _linkedList = _linkedList.next;
            return (_linkedList != null);
        }

        public void Reset()
        {
            _linkedList = null;
        }

        public void Dispose() {}

        public MyLinkedListNode<T> Current {
            get {
                try {
                    return _linkedList;
                }
                catch (NullReferenceException e) {
                    throw new NullReferenceException(e.Message);
                }
            }
        }

        T IEnumerator<T>.Current => Current.item;

        object System.Collections.IEnumerator.Current => Current;
    }
}