using System;

namespace Jang_Ju_Youn_ex3__2_
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                int j = 5;
                do
                {
                    Console.Write("*");
                    j--;
                }
                while (j > i);

                Console.WriteLine();
                i++;
            }
            while (i < 5);
        }
    }
}
