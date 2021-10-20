using System;

namespace Structures
{
    class Program
    {
        class LinkedList
        {
            private ListNode head;
            private ListNode tail;
            private int size;

            private class ListNode
            {
                public String value;
                public ListNode nextNode;
                public ListNode(String value)
                {
                    this.value = value;
                }
            }

            public void Append(LinkedList list, String value)
            {
                ListNode newNode = new ListNode(value);
                if (list.tail == null)
                {
                    list.head = newNode;
                }
                else
                {
                    tail.nextNode = newNode;
                }
                list.size++;
                list.tail = newNode;
            }
            public int getSize()
            {
                return size;
            }
            public void allValue(LinkedList list)
            {
                LinkedList tmp = list;
                int size = getSize();
                for (int i = 0; i < size; i++)
                {
                    System.Console.WriteLine(tmp.head.value);
                }
            }
            public void Unshift(LinkedList list, String value)
            {
                ListNode newNode = new ListNode(value);
                if (list.head == null)
                {
                    tail.nextNode = newNode;
                }
                else
                {
                    list.head = newNode;
                }
                list.size++;
                list.tail = newNode;
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(list, "First");
            list.Append(list, "Second");
            list.Unshift(list, "Third");
            list.Append(list, "Third");

            list.allValue(list);
        }
    }
}