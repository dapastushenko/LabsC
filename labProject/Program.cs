using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labProject
{
    class Program
    {
        static void Main(string[] args)
        {
            callYrName();
        }

        static void callYrName()
        {
            String myName;

            Console.WriteLine("Please write your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);

            Console.ReadKey();
        }

        static void Divider()
        {

        }

    }
}
