using System;

namespace Jang_Ju_Youn_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요 : ");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input); 

            if (number <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
