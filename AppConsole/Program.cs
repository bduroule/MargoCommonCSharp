using AlgorithmAndDataStruct;
using AlgorithmAndDataStruct;
using OrientedObjectProgramation;
using System;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyLinkedList<int> testList = new MyLinkedList<int>() {1, 1, 2, 4, 6, 7, 9};

            // var tab1 = new int[] {1, 3, 7, 9, 12, 45};
            // var tab2 = new int[] {2, 5, 8, 10, 11, 36};
            
            // // testList.Add(1);
            // // testList.Add(2);
            // testList.PrintList();
            // foreach (var elem in testList) {
            //     Console.WriteLine(elem.item);
            // }
            // testList.ReversList();
            // Console.WriteLine();

            // foreach (var elem in testList) {
            //     Console.WriteLine(elem.item);
            // }
            // var res = MergeTabInt.Merge(tab1, tab2);
            // Console.WriteLine("Tab = ");
            // foreach (var s in res) {
            //     Console.Write($"{s}, ");
            // }
            // Console.WriteLine();
            // Console.WriteLine($"Hello W {testList.SortMiddleList().item}");
            // Console.WriteLine();
            // SortNumberTab sortNumberTab = new SortNumberTab(new int[] {2, 4, 1, 8, 4, 6, 3, 22, 64, 10, 44, 56});
            // sortNumberTab.bubbleSort();

            // foreach (var elem in sortNumberTab.tab) {
            //     Console.Write($"{elem}, ");
            // }
            // Console.WriteLine();

            MultithreadingProductConsumer testTread = new MultithreadingProductConsumer();
            testTread.ProductConsumer();
        }
    }
}