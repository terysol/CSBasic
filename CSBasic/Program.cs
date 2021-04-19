using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "김" + "솔" + "민";
            /*  Console.Write("개행이 안되는  친구");
              Console.WriteLine("개행이 되는 친구");*/

            // string do= "안되는 거";
            var alpha = "알파";
            var 한글변수명 = "안녕";
            // 이모는 변수명으로 안됨.

            // 인라인 주석

            // 출력
            Console.WriteLine("개행이 되는 출력");
            /*  Console.Write("개행이 안되는 출력");*/

            // 정수 자료형
            Console.WriteLine(52);   // 기본 자료형은 정수형
            // Arithmetic Operator +, - ,*, / 
            Console.WriteLine(52 + 300);
            //연산자 우선순위 수학과 비슷 (Operator Priority)
            Console.WriteLine(5 + 3 * 2);

            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            // Real Number
            Console.WriteLine(52.276);

            Console.WriteLine(0);
            Console.WriteLine(0.0);

            Console.WriteLine(1.0 + 2.5);
            Console.WriteLine(1.0 - 2.5);
            Console.WriteLine(1.0 * 2.5);
            Console.WriteLine(1.0 / 2.5);

            Console.WriteLine(1.0 / 2.0);       // 소수점 나옴
            Console.WriteLine(1 / 2);
            // 소수가 나옴. (암묵적 형변환)
            Console.WriteLine(1.0 / 2);
            Console.WriteLine(1 / 2.0);

            Console.WriteLine('A');
            Console.WriteLine('가');
            /*Console.WriteLine('BB');*/
            Console.WriteLine("AB");

            // Escape Character
            Console.WriteLine("미림\t여자정보\t과학고");     // 4개 기준 
            Console.WriteLine("미림여자정보과학고\t안녕");
            Console.WriteLine("\\ 역슬래시 \n 엔터문자 \"큰따옴표");

            // 문자열 연결 연산자 Concatenation Operator
            Console.WriteLine("A" + "B");
            Console.WriteLine("A" + 1);
            Console.WriteLine(1 + "A");
            Console.WriteLine("1" + "1");
            Console.WriteLine('A' + 'B');
            Console.WriteLine('A' - 'B');
            /* Console.WriteLine("A" - "B");*/

            Console.WriteLine("안녕하세요"[0]);
            /*Console.WriteLin
             * e("안녕하세요"[-1]);*/

            // boll/ boolean
            Console.WriteLine(true);
            Console.WriteLine(false);   // 출력은 앞메 대문자

            //Comparison operator
            // == 1.!= <, >= 
            Console.WriteLine(62 < 273);
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);

            // Integer overflow
            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b);

            double c = 52.263;
            char d = '아';

            // sizeof
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));
            Console.WriteLine("bool: " + sizeof(bool));


            bool TrueOrFalse = true;

            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);

            output *= 2;
            Console.WriteLine(output);

            // 문자열 관련 복합 대입 연산자
            string str = "Hello";
            str += "World";
            str += "!";

            Console.WriteLine(str);

            // 증감연산자
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
            Console.WriteLine(number);

            number = 10;
            number++;
            Console.WriteLine(number);
            ++number;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
            --number;
            Console.WriteLine(number);
            Console.WriteLine(number);

        }
    }
}
