using System;

namespace Jang_Ju_Youn_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                int j = 0;
                do
                {
                    Console.Write("*");
                    j++;
                }
                while (j <= i);

                Console.WriteLine();
                i++;
            }
            while (i < 5);
        }
    }
}
