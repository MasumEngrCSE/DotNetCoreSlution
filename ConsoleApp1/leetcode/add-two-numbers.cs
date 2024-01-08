using com.sun.security.ntlm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.leetcode
{
    public class LinkListCls
    {
        ListNode rt;
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string nodeStr1 = "", nodeStr2 = "";

            while (l1 != null)
            {
                nodeStr1 = l1.val.ToString() + nodeStr1;
                l1 = l1.next;
            }


            while (l2 != null)
            {
                nodeStr2 = l2.val.ToString() + nodeStr2;
                l2 = l2.next;
            }

            BigInteger v1 = BigInteger.Parse(nodeStr1);
            BigInteger v2 = BigInteger.Parse(nodeStr2);

            BigInteger re = v1 + v2;

            foreach (char i in re.ToString())
            {
                ListNode newnode = new ListNode(Convert.ToInt32(i.ToString()));
                newnode.next = rt;
                rt = newnode;
            }
            return rt;
        }




        public void AddTwoLinkList()
        {
            //AddTwoNumbers(head1, head2);

            //Node 1
            pushListNode(1, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(0, 1);
            pushListNode(1, 1);
            //F3
            //pushListNode(9, 1);


            //F2
            //pushListNode(9, 1);
            //pushListNode(4, 1);
            //pushListNode(2, 1);

            //F1
            //pushListNode(2, 1);
            //pushListNode(4, 1);
            //pushListNode(3, 1);

            //Node 2:---------------------------------------------
            pushListNode(4, 2);
            pushListNode(6, 2);
            pushListNode(5, 2);

            //F3
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(9, 2);
            //pushListNode(1, 2);



            //F2
            //pushListNode(9, 2);
            //pushListNode(4, 2);
            //pushListNode(6, 2);
            //pushListNode(5, 2);

            //F1
            //pushListNode(5, 2);
            //pushListNode(6, 2);
            //pushListNode(4, 2);


            printlist(head1);
            Console.WriteLine("");
            printlist(head2);





            ListNode ret = AddTwoNumbers(head1, head2);
            Console.WriteLine();
            printlist(ret);
        }


        public void printlist(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }


        public ListNode AddTwoNumbersPrev(ListNode l1, ListNode l2)
        {
            //ListNode rt;
            int lnLen = getsize(l1);
            int ln2Len = getsize(l2);
            int[] node1 = new int[lnLen];
            int[] node2 = new int[ln2Len];

            string nodeStr1 = "", nodeStr2 = "";

            int l = 0;
            while (l1 != null)
            {
                nodeStr1 = nodeStr1 + l1.val.ToString();
                //node1[l] = l1.val;
                //l++;

                l1 = l1.next;
            }

            l = 0;
            while (l2 != null)
            {

                nodeStr2 = nodeStr2 + l2.val.ToString();
                //node2[l] = l2.val;
                //l++;

                l2 = l2.next;
            }
            //Console.WriteLine("l2 to node2 Array");

            //node1.Reverse();
            //node2.Reverse();

            int v1 = Convert.ToInt32(nodeStr1);
            //int v1 = Convert.ToInt32(string.Join("", node1));


            int v2 = Convert.ToInt32(nodeStr2);
            //int v2 = Convert.ToInt32(string.Join("", node2));

            int re = v1 + v2;
            //Console.WriteLine(re);

            foreach (char i in re.ToString())
            {
                ListNode newnode = new ListNode(Convert.ToInt32(i.ToString()));
                newnode.next = rt;
                rt = newnode;
            }


            //rt = result;

            return rt;
        }

        ListNode head1, head2, result;
        int carry;
        // A utility function to push a 
        // value to linked list 
        public void pushListNode(int val, int list)
        {
            ListNode newnode = new ListNode(val);

            if (list == 1)
            {
                newnode.next = head1;
                head1 = newnode;
            }
            else if (list == 2)
            {
                newnode.next = head2;
                head2 = newnode;
            }
            else
            {
                newnode.next = result;
                result = newnode;
            }

        }


        public void pushListNode2(ListNode nodeToAdd, int val)
        {

            ListNode newnode = new ListNode(val);

            newnode.next = nodeToAdd;
            nodeToAdd = newnode;
        }


        int getsize(ListNode head)
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


}
