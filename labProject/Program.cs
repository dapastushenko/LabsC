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
            divider();
        }

        static void callYrName()
        {
            String myName;

            Console.WriteLine("Please write your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);

            Console.ReadKey();
        }

        static void divider()
        {
            try{
                Console.WriteLine("Введите целое число!");
                String str = Console.ReadLine();
                int i = Int32.Parse(str);

                 Console.WriteLine("Введите второе число!");
                str = Console.ReadLine();
                int j = Int32.Parse(str);
                int k=i/j;

                Console.WriteLine("Результат деления {0} на {1}: {2}",i,j,k);
                Console.ReadKey();
                }catch(DivideByZeroException e){
                    Console.WriteLine("Ошибка: {0}", e);
                }
               
        }

    }
}
