﻿using System;

namespace Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("계속 할까요?(예/아니요) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }
        }
    }
}
