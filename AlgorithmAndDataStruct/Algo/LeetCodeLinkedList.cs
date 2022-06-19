namespace AlgorithmAndDataStruct;


// Definition for singly-linked list.
public class ListNode 
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
 }
 
public static class LeetCodeLinkedList
{
    public static void DeleteNode(ListNode node) {
        if (node == null || node.next == null) {
            
            return ;
        }
        ListNode tmp = node.next;
        node = null;
        node = tmp;
    }

    public static ListNode RemoveElement(ListNode head, int n) {
        if (head == null || head.next == null)
            return null;
        if (head.val == n)
            return head.next;
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null) {
            if (prev != null && curr.next != null && curr.val == n)
                prev.next = curr.next;
            if (curr.next != null && curr.next.val == n) {
                if (curr.next.next == null)
                    curr.next = null;
                else
                    prev = curr;
            }
            curr = curr.next;
        }
        return head;
    }

        public static ListNode RemoveElement(ListNode head, ListNode node) {
        if (head == null || head.next == null)
            return null;
        if (head.Equals(node))
            return head.next;
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null) {
            if (prev != null && curr.next != null && curr.Equals(node))
                prev.next = curr.next;
            if (curr.next != null && curr.next.Equals(node)) {
                if (curr.next.next == null)
                    curr.next = null;
                else
                    prev = curr;
            }
            curr = curr.next;
        }
        return head;
    }

    public static ListNode RemoveNthFromEnd(ListNode head, int n) {
        int size = 0;
        ListNode tmpList = head;

        while (tmpList != null) {
            size++;
            tmpList = tmpList.next;
        }
        tmpList = head;
        int count = 0;
        while (tmpList != null) {
            if (size - n == count)
                return RemoveElement(head, tmpList);
            count++;
            tmpList = tmpList.next;
        }
        return null;
    }

    public static ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null)
            return null;
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        ListNode result = new ListNode(list1.val <= list2.val ? list1.val : list2.val);
        if (list1.val <= list2.val)
            list1 = list1.next;
        else
            list2 = list2.next;
        ListNode tmpResult = result;

        
        while (list1 != null && list2 != null) {
            //Console.WriteLine($"IN {list1.val} {list2.val}");

            if (list2 == null || list1.val <= list2.val) {
                tmpResult.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else if (list1 == null || list1.val > list2.val) {
                tmpResult.next = new ListNode(list2.val);
                list2 = list2.next;
            }

            tmpResult = tmpResult.next;
        }
        while (list1 != null) {
            tmpResult.next = new ListNode(list1.val);
            list1 = list1.next;
            tmpResult = tmpResult.next;
        }
        while (list2 != null) {
            tmpResult.next = new ListNode(list2.val);
            list2 = list2.next;
            tmpResult = tmpResult.next;
        }
        return result;
    }

    public static bool HasCycle(ListNode head) {
        if (head == null || head.next == null)
            return false;
        ListNode hare = head.next;
        ListNode tortoise = head;

        while (true) {
            if (tortoise == null || hare == null || hare.next == null)
                return false;
            if (tortoise == hare)
                return true;
            tortoise = tortoise.next;
            hare = hare.next.next;
        }
    }

    public static ListNode ReverseList(ListNode head) {
        ListNode current = head, previous = null, next = null;

        while (current != null) {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return previous;
    }
}