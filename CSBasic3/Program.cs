using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            /*for (int i2 = '가'; i2 <= '힣'; i2++)
            {
                Console.Write((char)i2);
            }*/

            /*for(int i= intArray3.Length-1; i >= 0; i--)
            {
                Console.WriteLine(intArray3[i]);
            }*/

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

           /* for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }*/

           /* for (i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.WriteLine(' ');
                for (int j = 0; j < i + 1; j++)
                    Console.WriteLine('*');
                Console.WriteLine('\n');
            }*/

            string inputString = "Potato Tomato";
            inputString.ToUpper();
            Console.WriteLine(inputString);
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(inputString);
            Console.WriteLine(input.ToLower());

            string foodString = "감자 고구마 토마토";
            string[] foods = foodString.Split(new char[] { ' ' });
            foreach (var item in foods)
            {
                Console.WriteLine(item);
            }

            string pathString = "C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;%JAVA_HOME%\\bin;C:\\git\\Git\\cmd;C:\\Program Files\\dotnet\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;C:\\Nodejs\\nodejs\\;";
            string[] paths = pathString.Split(new char[] { ';' });
            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }

            string StrangeInput = "test \n        \n";
            Console.WriteLine("[" + StrangeInput + "]");
            Console.WriteLine("[" + StrangeInput.Trim() + "]");

            string[] foodsArray = { "감자", "고구마", "토마토" };
            Console.WriteLine(string.Join(" ",foodsArray));

            Console.Clear();
            Console.WriteLine("포맷 중 :  0% [__________]");
 
            for(int f = 0; f < 10; f++)
            {
                
                Console.SetCursorPosition(0, 0);
                Console.Write("포맷 중 : ");
                Console.Write((f + 1) * 10 + "%[");
                for(int f2 = 0; f2 < f; f2++)
                    Console.Write("#");
                for (int f2 = f+1; f2 < 10; f2++)
                    Console.Write("_");
                Console.WriteLine("]");
                Thread.Sleep(1000);
            }
            Thread.Sleep(3000);
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x,5);
                if (x % 3 == 0)
                    Console.WriteLine("__0");
                else if (x % 3 == 1)
                    Console.WriteLine("_^0");
                else
                    Console.WriteLine("^_0");
                Thread.Sleep(1000);
                x++;
            }
        }
    }
}
