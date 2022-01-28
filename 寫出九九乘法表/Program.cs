using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九乘法表 Multiplication Table");
            string text = "";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    text = i + "x" + j + "=" + i * j;
                    Console.Write(text + "\t");
                }
                Console.Write("\r\n");
            }

        }
    }
}


