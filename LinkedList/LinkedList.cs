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


        public void DeleteNode(object data)
        {

            try
            {


            if (head.next == null)
            {
                Console.WriteLine("Linked List is Empty");
            }


            Node nodeToDelete = Find(data);

                if (nodeToDelete == null)
                {
                    ArgumentNullException e = new ArgumentNullException();
                    throw e;
                }
                else
                {

                    Node temp = head;

                    while (temp.next != null)
                    {
                        if(temp.next == nodeToDelete)
                        {

                            temp.next = temp.next.next;

                        }
                        else
                        {
                            temp = temp.next;
                        }

                    }



                }
            

            } catch ( ArgumentNullException e) {

                Console.WriteLine(e.Message);

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


        private Node Find(object data)
        {
            if (head.next == null)
            {
                //Console.WriteLine("Linked List is Empty");
                return null;
            }
            else
            {

                Node temp = head.next;

                while (temp.next != null)
                {
                    if (temp.Data.Equals(data))
                    {

                        return temp;

                    }
                    else
                    {

                        temp = temp.next;

                    }

                }

                return null;

                }
        
            }
    }

}
