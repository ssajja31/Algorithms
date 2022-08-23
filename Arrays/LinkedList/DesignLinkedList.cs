/**
 * Definition for singly-linked list.
 * class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {this.val = x; this.next = null;}
 * }
 */
class Solution
{
    public ListNode insert(ListNode head, int position, int value)
    {
        if (position == 0)
        {
            ListNode temp = new ListNode(value);
            temp.next = head;
            head = temp;
        }
        else
        {
            ListNode temp = head;
            int i = 0;
            while (i < position - 1)
            {
                temp = temp.next;
                i++;
            }

            ListNode newNode = new ListNode(value);
            newNode.next = temp.next;
            temp.next = newNode;
        }

        return head;
    }

    public ListNode delete(ListNode head, int position)
    {
        if (position == 0)
        {
            head = head.next;
        }
        else
        {
            ListNode temp = head;
            int i = 0;

            while (i < position - 1)
            {
                temp = temp.next;
                i++;
            }
            temp.next = temp.next.next;
        }

        return head;
    }

    public int size(ListNode head)
    {
        ListNode temp = head;
        int count = 0;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }

        return count;
    }
    public ListNode solve(List<List<int>> A)
    {
        ListNode head = null;

        for (int i = 0; i < A.Count; i++)
        {
            List<int> list = A[i];

            if (list[0] == 0 && list[2] == -1)
            {
                head = insert(head, 0, list[1]);
            }
            else if (list[0] == 1 && list[2] == -1)
            {
                head = insert(head, size(head), list[1]);
            }
            else if (list[0] == 2)
            {
                head = insert(head, list[2], list[1]);
            }
            else if (list[0] == 3)
            {
                if (list[1] < size(head))
                {
                    head = delete(head, list[1]);
                }
            }
        }

        return head;
    }
}
