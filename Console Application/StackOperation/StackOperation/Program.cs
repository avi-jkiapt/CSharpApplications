using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Operation");
            Stack st = new Stack();
            st.Push(5);
            st.Push(2);
            st.Push(3);
            printStack(st);
            st.Push(1);
            st.Push(9);
            st.Push(7);
            printStack(st);
            Console.WriteLine("Peep at top : " + st.Peek());
            printStack(st);
            st.Pop();
            Console.WriteLine("After Pop Operation ");
            printStack(st);


            Console.ReadLine();
        }

        public static void printStack(Stack st)
        {
            Console.WriteLine("Present Stack: ");
            foreach (Object o in st)
            {
                Console.Write(o +" ");
            }
            Console.WriteLine();
        }
    }
}
