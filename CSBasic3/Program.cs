﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 172, 13, 13, 103 };
            intArray[2] = 0;

            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length);

            int[] intArray2 = new int[100];
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[99]);

            int i = 0;
            int[] intArray3 = { 52, 273, 32, 65, 103 };
            while (i < intArray3.Length)
            {
                Console.WriteLine(i + "번쩨 출력 : " + intArray3[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료) : ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("go 공지사항");
                        break;
                    case "2":
                        Console.WriteLine("go 오늘의 점심");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        break;
                }
            } while (input != "exit");

            /*or (int i2 = '가'; i2 <= '힣'; i2++)
            {
                Console.Write((char)i2);
            }*/

            for(int i= intArray3.Length-1; i >= 0; i--)
            {
                Console.WriteLine(intArray3[i]);
            }
        }
    }
}
