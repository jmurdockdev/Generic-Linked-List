using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            numbers.TraverseList();

            Console.ReadKey();
        }
    }
}
