using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter string to reverse:");
            //String str = Console.ReadLine();

            //Utils.Reverse(ref str);
            //Console.WriteLine(str);
            CopyFileUpper.CopyFile();

            Console.ReadKey();
        }
    }
    class Utils
    {
        public static void Reverse(ref string str)
        {
            String sRev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sRev = sRev + str[i];
            }
            str = sRev;
        }
    }
    class CopyFileUpper
    {
        public static void CopyFile()
        {
            Console.WriteLine("Copy from:");
            string fileFrom = Console.ReadLine();

            Console.WriteLine("Copy to:");
            string fileTo = Console.ReadLine();
            try
            {
                StreamReader streamReader = new StreamReader(fileFrom);
                StreamWriter streamWriter = new StreamWriter(fileTo);

                while (streamReader.Peek() != -1)
                {
                    string uCaseString = streamReader.ReadLine();
                    uCaseString = uCaseString.ToUpper();
                    streamWriter.WriteLine(uCaseString);
                }
                streamReader.Close();
                streamWriter.Close();
            }catch(FieldAccessException e)
            {
                Console.WriteLine(e.ToString());
            }catch(FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }


    }
}
