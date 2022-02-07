using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select any key to quit");
            Console.WriteLine("       1 for IF statement test!");
            Console.WriteLine("       2 for While loop test !");
            Console.WriteLine("----------------------");
            int sel = Convert.ToInt32(Console.ReadLine());
            switch (sel)
            {
                // 1 for IF statement test
                // 2 for 
                case 1:
                    Selection();
                    break;
                case 2:
                    SelectWhile();
                    break;
                default:
                    break;
            }
        }

        static void Selection()
        {
            Console.WriteLine("IF statement test. Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If Statement");
            if (num>7)
            {
                Console.WriteLine(num + " is more than 7");
            }
            else
            {
                Console.WriteLine(num + " is not more than 7");
            }

        }

        static void SelectWhile()
        {
            Console.WriteLine("While statement test. Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("While Loop");
            while(num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.WriteLine("End of While Loop");
        }
    }
}
