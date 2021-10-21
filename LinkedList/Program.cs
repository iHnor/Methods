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
            public void Unshift(LinkedList list, String value)
            {
                ListNode newNode = new ListNode(value);
                if (list.tail == null)
                {
                    list.head = newNode;
                    list.tail = newNode;
                }
                else
                {
                    newNode.nextNode = list.head;
                    list.head = newNode;
                }
                list.size++;
            }
            public int getSize()
            {
                return size;
            }
            public void allValue(LinkedList list)
            {
                ListNode tmp = list.head;
                while (tmp != null)
                {
                    System.Console.WriteLine(tmp.value);
                    tmp = tmp.nextNode;
                }
            }
            public void changeValue(LinkedList list, int id, string newValue)
            {
                ListNode tmp = list.head;
                if (0 < id && id < getSize())
                {
                    for (int i = 1; i != id; i++)
                    {
                        tmp = tmp.nextNode;
                    }
                    tmp.value = newValue;
                }
                else
                    System.Console.WriteLine("An element with this id does not exist!");
            }

            public void removeElement(LinkedList list, int id)
            {
                ListNode total = list.head;
                ListNode before = null;
                if (id == 1)
                {
                    list.head = total.nextNode;
                }
                else
                {
                    for (int i = 1; i != id; i++)
                    {
                        before = total;
                        total = total.nextNode;
                    }
                    if (list.tail != null)
                        before.nextNode = total.nextNode;
                    else
                        before.nextNode = null;
                }
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(list, "First");
            list.Append(list, "Second");
            list.Unshift(list, "New");
            list.Append(list, "Third");

            // list.allValue(list);

            list.changeValue(list, 3, "Change Value");
            // System.Console.WriteLine();
            // list.allValue(list);

            // System.Console.WriteLine();
            list.removeElement(list, 4);
            // list.allValue(list);

        }
    }
}