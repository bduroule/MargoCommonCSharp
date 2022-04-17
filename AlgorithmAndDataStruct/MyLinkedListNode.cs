using System;
using System.Collections.Generic;

namespace AlgorithmAndDataStruct
{
    public class MyLinkedListNode<T>
    {
        public MyLinkedListNode() {}

        public T item { get; set; }
        public MyLinkedListNode<T>? next  { get; set; }
        public MyLinkedListNode<T>? previus  { get; set; }
    }
}