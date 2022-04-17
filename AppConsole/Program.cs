using AlgorithmAndDataStruct;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> testList = new MyLinkedList<int>() {1, 1, 2, 4, 6, 7, 9};
            // testList.Add(1);
            // testList.Add(2);
            testList.PrintList();
            foreach (var elem in testList) {
                Console.WriteLine(elem.item);
            }
            testList.ReversList();
            Console.WriteLine();

            foreach (var elem in testList) {
                Console.WriteLine(elem.item);
            }
            Console.WriteLine($"Hello W {testList.SortMiddleList().item}");
        }
    }
}