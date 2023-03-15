using System;

namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("정수 2개와 연산기호를 입력해주세요!");
            Console.WriteLine();
            Console.Write("첫번째 정수를 입력해주세요. : ");
            string input1 = Console.ReadLine();
            Console.Write("두번째 정수를 입력해주세요. : ");
            string input2 = Console.ReadLine();
            Console.Write("연산기호를 입력해주세요. ex)+,-,*./,% : ");
            string input3 = Console.ReadLine();

            int a = int.Parse(input1);
            int b = int.Parse(input2);
            int value = 0;
            

            switch (input3)
            {
                case "+":
                   value = a + b;
                    break;
                case "-":
                    value = a - b;
                    break;
                case "*":
                    value = a * b;
                    break;
                case "/":
                    value = a / b;
                    break;
                case "%":
                    value = a % b;
                    break;
                
            }
            Console.WriteLine($"입력하신 {a}{input3}{b}의 결과값은 {value} 입니다.");
        }
    }
}
