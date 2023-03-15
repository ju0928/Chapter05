using System;

namespace P151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요. : ");

            string input1 = Console.ReadLine();

            Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요. : ");

            string input2 = Console.ReadLine();

            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요. : ");

            string input3 = Console.ReadLine();

            int a = Convert.ToInt32(input1);
            int b = Convert.ToInt32(input2);
            int c = Convert.ToInt32(input3);
            int max;
            int min;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }

            }
            else
            {
                if (c > b)
                {
                    max = c;
                }
                else
                {
                    max = b;
                }
            }

            if (a < b)
            {
                if (a < c)
                {
                    min = a;
                }
                else
                {
                    min = c;
                }

            }
            else
            {
                if (c < b)
                {
                    min = c;
                }
                else
                {
                    min = b;
                }
            }

            int sum = a + b + c;
            int Average = sum / 3;


            Console.WriteLine($"입력하신 {a},{b},{c} 중 최대값은 {max} 이며, 최소값은 {min} 입니다.");
            Console.WriteLine($"입력하신 {a},{b},{c} 의 합은 {sum} 이며, 평균은 {Average} 입니다.");


           
        }
    }
}
