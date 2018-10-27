namespace LinkedList
{

    public class Node
    {

        private object data;
        public object Data
        {
            get => data;
            set => data = value;
        }
        
        public Node next;

        
        public Node(object data)
        {
            this.data = data;
            this.next = null;
        }

    }

}