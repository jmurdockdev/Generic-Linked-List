using System;


namespace LinkedList
{
    class Program
    {
        /// <summary>
        /// Sandbox environment for LinkedList
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            LinkedList numbers = new LinkedList();

            for (int i = 0; i < 10; i++)
            {
                numbers.AddNode(i);
            }

            numbers.DeleteNode(8);
            numbers.DeleteNode(9);
            numbers.DeleteNode(9);
            numbers.TraverseList();

            Console.ReadKey();
        }
    }
}
