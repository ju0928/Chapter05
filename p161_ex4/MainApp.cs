using System;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요 : ");
            string month = Console.ReadLine();
            
            switch (month)
            {
                case "12":
                case "1":
                case "2":
                    Console.WriteLine($"입력하신 {month}은 겨울 입니다.");
                    break;
                case "3":
                case "4":
                case "5":
                    Console.WriteLine($"입력하신 {month}은 봄 입니다.");
                    break;
                case "6":
                case "7":
                case "8":
                    Console.WriteLine($"입력하신 {month}은 여름 입니다.");
                    break;
                case "9":
                case "10":
                case "11":
                    Console.WriteLine($"입력하신 {month}은 가을 입니다.");
                    break;
                default:
                    Console.WriteLine("입력하신 숫자는 잘못되었습니다. 확인 후 다시 실행해 주세요.");
                    return;

            }

        }

        
    }
}
