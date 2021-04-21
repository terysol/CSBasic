using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        string Var="테스트";
        //var something = "아하하";   -> 불가능

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

            int _int = 273;
            long _long = 3493749738;
            float _float = 52.34F;
            char _char = '글';
            string _string = "문자열 ";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
            Console.WriteLine((2211111111L).GetType());

            var number3 = 100;   // 할당되는 값에 따라서 자료형을 정해준다. 타입 변경 불가능
            // var number4;  -> 에러 남. 초기화도 해줘야 함. 
            var number5 = 100.0;
            var number6 = 100.0F;

            // string input = Console.ReadLine();
            //Console.WriteLine("input : " + input);

            // echo server
            /*while (true)
            {
                input = Console.ReadLine();
                if(input != "q")
                {
                    Console.WriteLine(input);
                }
                else
                {
                    break;
                }
            }*/

            // 강제 형변환
            long longNumber = 100;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            // 자동형변환
            intNumber = 100;
            longNumber = intNumber;
            Console.WriteLine(longNumber);

            // int -> long, float, double
            // long -> float, double
            // char -> int, long, float, double
            // float -> double

            // Widening Casting 자동형변환
            // byte -> short -> char -> int  -> long -> float -> double

            // Narrowing Casting 강제 형변환
            // double -> float -> long -> int -> char -> short -> byte

            // int.Parse() / long.Parse()
            // float.Parse() / double.Parse()
            string numberString = "3234";
            intNumber = int.Parse(numberString);
            Console.WriteLine(intNumber);


            try
            {
                Console.WriteLine(int.Parse("43.567"));
                Console.WriteLine("오십일");
                Console.WriteLine("Seven");
            }
            catch (FormatException e)
            {
                Console.WriteLine("숫자로 변경할 수 없습니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine("알 수 없는 오류 : " + e.Message);
            }

            // 다른 자료형을 문자열로 변환
            Console.WriteLine((10).ToString());
            Console.WriteLine((52.378).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            double number2 = 52.273103;
            Console.WriteLine(number2.ToString("0.0"));
            Console.WriteLine(number2.ToString("0.00"));
            Console.WriteLine(number2.ToString("0.000"));
            Console.WriteLine(number2.ToString("0.0000"));

            Console.WriteLine(52 + "");   // 문자열
            Console.WriteLine(52 + 3 + "");
            Console.WriteLine("" + 52 + 3);
            Console.WriteLine(52 + "" + 3);

            number = 273;
            string outputA = number + "";
            Console.WriteLine(outputA);

            char ch = 'a';
            string outputB = ch + "";
            /*string outputC = ch;*/  // 문자를 문자열에 넣지 못함.
            Console.WriteLine(outputB);

            // string to bool 변환
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("trUe"));
            Console.WriteLine(bool.Parse("False"));
            Console.WriteLine(bool.Parse("false"));

            // 최댓값 최솟값은 상수로 !
            Console.WriteLine(-1 * int.MaxValue);
            // Console.WriteLine(-1 * int.MinValue);   // 범위가 넘어가기 때문에 오류
            Console.WriteLine(-1L * int.MinValue);  



        }
    }
}
