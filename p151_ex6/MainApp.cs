using System;

namespace p151_ex6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("중간고사 점수 합격여부 프로그램.");
            Console.WriteLine();
            Console.Write("현재 본인의 학년을 숫자로만 입력하세요.(ex.2) : ");
            string input1 = Console.ReadLine();
            Console.Write("현재 본인의 점수를 입력해 주세요.(ex.85) : ");
            string input2 = Console.ReadLine();

            int a = int.Parse(input1); //사용자의 학년
            int b = int.Parse(input2); //사용자의 점수

            int score1 = 70; //4학년 합격점수
            int score2 = 60; //그 외 합격점수

            if (b >= score2)
            {    
                Console.WriteLine($"입력하신 점수 {input2}는(은) 합격 입니다.");
            }
            else if (b <= score2 )
            {
                Console.WriteLine($"입력하신 점수 {input2}는(은) 불합격 입니다.");
            }
            

            else 
            {
                Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
            }

           

        }
    }
}
