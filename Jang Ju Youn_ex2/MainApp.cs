using System;


namespace Jang_Ju_Youn_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
