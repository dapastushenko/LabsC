using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first num");
            int x = int.Parse(Console.ReadLine);
            Console.WriteLine("Input secon num");
            int y = int.Parse(Console.ReadLine);

            int greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is:" + greater);

            Console.WriteLine("Befor swap:" + x + ", " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap:" + x + "," + y);

            //3 задача
            bool fact = Utils.Factorial(x, out f);
            if (ok)
            {
                Console.WriteLine("Factorial x(" + x + ")=" + f);
            }
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }

    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
                return b;

        }

        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;

            if (ok < 0) ok = false;
            try
            {
                checked
                {
                    for (k = 2; k <= n; ++k)
                    {
                        f *= k;
                    }
                }
            }catch(Exception e) 
            {
                f = 0;
                ok = false;
                //Console.WriteLine(e);
            }
            answer = f;
            return ok;
        }
    }
}
