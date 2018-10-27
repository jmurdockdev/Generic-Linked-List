using System;

namespace LinkedList
{

    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            this.head = new Node(null);
        }

        public void AddNode(object data)
        {

            Node node = new Node(data);

            if (head.next == null)
            {
                this.head.next = node;

            }
            else
            {

                Node temp = head;

                while (temp.next != null)
                {

                    temp = temp.next;

                }

                temp.next = node;

            }

        }


        public void RemoveNode(Node node)
        {

            if (head.next == null)
            {
                Console.WriteLine("Linked List is Empty");
            }


            Node temp = head;

            while (temp.next != null)
            {

                if (temp.next == node)
                {
                    temp.next = node.next;
                    node = null;
                    break;
                }
                else
                {

                    temp = temp.next;

                }

            }


        }


        public void TraverseList()
        {
            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;

                Console.WriteLine(temp.Data);
            }


        }



    }

}
