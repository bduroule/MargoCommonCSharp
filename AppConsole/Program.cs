using AlgorithmAndDataStruct;
using OrientedObjectProgramation;
using System;
using System.Collections;
using Kata;

namespace AppConsole
{
    class Program
    {

        static void mapTree(BinaryTreeNode<int> root, string str)
        {
            Console.WriteLine($"    node = {root.Value} string {str}");
            if (root.left != null)
                mapTree(root.left, "left");
            if (root.reight != null)
                mapTree(root.reight, "reight");
        }
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
            // int[] array = new int[] {2, 4, 1, 8, 4, 6, 3, 22, 64, 10, 44, 56};
            int[] array2 = new int[] {1, 2, 3, 4, 5, 6, 7, 8};

            var test = LeetCodeArray.PlusOne(new int[] {0});

            foreach (var elem in test) {
                Console.Write($"{elem}, ");
            }
            Console.WriteLine();

            // foreach (var elem in tab) {
            //     Console.Write($"{elem}, ");
            // }

            // Console.WriteLine();
            // SortNumberTab.QuickSort(array, 0, array.Length - 1);

            // foreach (var elem in array) {
            //     Console.Write($"{elem}, ");
            // }
            // Console.WriteLine();

            // MultithreadingProductConsumer testTread = new MultithreadingProductConsumer();
            // LinkedList<int> list = new LinkedList<int>(new int[] {2, 4, 6, 7, 8, 10, 11, 12});
            // LinkedListNode<int> node = list.First;
             
            // BinarySearchTree<int> tree = new BinarySearchTree<int>(new int[] {2, 4, 6, 7, 8, 10, 11, 12});
            // SetOfSet.result3(4, 3);
            // tree.Add(7);
            // tree.Add(4);
            // tree.Add(2);
            // tree.Add(6);
            // tree.Add(11);
            // tree.Add(9);
            // tree.Add(12);
            // tree.Add(8);
            // tree.Add(10);
            // mapTree(tree.root, "root");
            // Console.WriteLine($"Max = {tree.MaxHeight()}");
            // BinaryTreeNode<int> test = tree.ClosestAncestor(tree.Search(8), tree.Search(12));
            // Console.WriteLine($"ancetor {test.Value}");
            // testTread.ProductConsumer();

            Console.WriteLine($"test first |{LeetCodeString.LongestCommonPrefix(new string[] {"test", "tewssss", "coucou" })}|");
            Console.WriteLine($"test blalba = {SortNumberTab.MoreLonger(new ArrayList() {12343434, "coucou", "test", 12, "je suis un poulet", 1})}");

            ListNode root = new ListNode(1);
            root.next = new ListNode(2);
            // root.next.next = new ListNode(5);
            // root.next.next.next = new ListNode(9);
            // root.next.next.next.next = new ListNode(10);
            // root.next.next.next.next.next = null;

            // LeetCodeLinkedList.RemoveNthFromEnd(root, 1);

            // while (root != null) {
            //     Console.Write($"{root.val}, ");
            //     root = root.next;
            // }
            // Console.WriteLine();

            // string[] numbers = new string[] {
            //     "    _  _  _  _  _  _     _ ",
            //     "|_||_|| || ||_   |  |  ||_ ",
            //     "  | _||_||_||_|  |  |  | _|"
            // };
            // string[] numbers2 = new string[] {
            //     "    _  _     _  _  _  _  _ ",
            //     "  | _| _||_||_ |_   ||_||_|",
            //     "  ||_  _|  | _||_|  ||_| _|"
            // };
            // BankOCR bank = new BankOCR();

            // int testNum = '3' - '0';
            // string AccNumber = bank.ConvertFileToNumber(numbers);
            // string key = "!)\"(£*%&><@abcdefghijklmno";
            // string resCode = CodeCracker.Decrypte(")dc<djgh a£!", key);
            // dynamic testDim = "coucou";
            // Console.WriteLine($"test 1 dim = {testDim}");
            // testDim = 4;
            // Console.WriteLine($"test 2 dim = {testDim}");


            // Console.WriteLine($"bank =          {AccNumber} | {bank.IsValidAccountNumber("345882865")}\n\t{bank.DefineStatusCode("3458?2865")}\n\t{bank.DefineStatusCode(AccNumber)}\n\t{bank.DefineStatusCode("345882865")}");
            // Console.WriteLine($"CodeCracker     {resCode} | {CodeCracker.Encrypte(resCode, key)}");
            // Dictionary<string, string> dictionary = new Dictionary<string, string>();
            // dictionary.Add("jejej", "jes suis un");
            // dictionary.Add("quiFaitDesTruc", "je suis deux"); var a = "coucou $jejej$ sui un lapin $quiFaitDesTruc$ ui";
            // var ui = DictionaryReplacer.Replacer("$jejej$$quiFaitDesTruc$", dictionary);
            // Console.WriteLine($" result replacer = |{ui}|");

            /*
            ** Gamme
            */

            // Gamme gamme = new Gamme();

            // gamme.PrintNote();

            // Console.WriteLine();
            // Console.WriteLine("________________________________________________________");
            // Console.WriteLine();
            // Console.WriteLine($"Gamme {gamme.GetGamme(args[0], args[1])}");

            /*
            ** Gamme
            */

            // Console.WriteLine($"{(count % 11 > 7 ? 11 - count % 11 + 1 : count % 11)}{(count % 11 > 7 ? 'b' : '#')} || {i} ==== {ParseNote(note)} ");
            Console.WriteLine();

            ListNode testList1 = new ListNode(0);
            // ListNode testList2 = new ListNode(1);

            testList1.next = new ListNode(1);
            testList1.next.next = new ListNode(2);
            testList1.next.next.next = new ListNode(3);
            testList1.next.next.next.next = new ListNode(4);

            ListNode resultList = LeetCodeLinkedList.ReverseList(testList1);


            // testList2.next = new ListNode(3);
            // testList2.next.next = new ListNode(4);
            // testList2.next.next.next = new ListNode(5);
            // testList2.next.next.next.next = new ListNode(8);
            // testList2.next.next.next.next = testList2.next;


            // // ListNode resultList = LeetCodeLinkedList.MergeTwoLists(testList1, testList2);
            // ListNode resultList = LeetCodeLinkedList.MergeTwoLists(null, null);

            // Console.WriteLine($"coucou je suis la ({resultList})"); 

            while (resultList != null) {
                Console.Write($"{resultList.val}->");
                resultList = resultList.next;
            }
            Console.WriteLine();

            // var testArray = new int[] {2, 0};

            // LeetCodeSortingAndSearching.Merge(testArray, 1, new int[] {1}, 1);

            // Console.WriteLine($"merge Array");
            // foreach (var elem in testArray) {
            //     Console.Write($"{elem}, ");
            // }

            // var result = LeetCodeArray.TwoSum(new int[] {3,2,3}, 6);

            // foreach (var e in result) {
            //     Console.Write($"{e} ");
            // }
            // Console.WriteLine();
            // Console.WriteLine($"test atoi => {"21474836460".MyAtoi()} || {"21474836460".AtoiLeet()}");

            // Console.WriteLine($" coucou fib {LeetCodeMatth.LenLongestFibSubseq(new int[] {1,2,3,4,5,6,7,8})}  |  {LeetCodeMatth.Tribonacci(5)}");

            var testArr = new int[] {-4,-1,0,3,10}.SortedSquares();
            testArr = new int[] {2,1,-1};
            Console.WriteLine($"piv = {testArr.PivotIndex()}");


            foreach (var e in testArr) {
                Console.Write($"{e}, ");
            }

            // Console.WriteLine($"rev Words {LeetCodeString.LengthOfLongestSubstring("abcabcbb")}");

        }
    }
}