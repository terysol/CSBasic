using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiClass ml = new MultiClass();
            Console.WriteLine(ml.Multi(52, 273));
            Console.WriteLine(ml.Multi(103, 32));
            ml.Print();
            Console.WriteLine(ml.Sum(1, 100));
            Console.WriteLine((52));
            Console.WriteLine((273));
            Console.WriteLine((52.273));

            ml.somePublic();
            
            
        }
        class MyMath
        {
            public static void Abs(int input)
            {
                Console.WriteLine("정수 : " + ((input < 0) ? -input:input));
                // return (input < 0) ? -input : input;
            }

            public static void Abs(double input)
            {
                //  return (input < 0) ? -input : input;
                Console.WriteLine("정수 : " + ((input < 0) ? -input:input));
            }
            public static void Abs(long input)
            {
                Console.WriteLine("정수 : " + ((input < 0) ? -input:input));
                //
            }
        }
        class MultiClass
        {
            public void somePublic()
            {
                Console.WriteLine("public !");
            }
            void someDefault()      // C#은 DEFAULT가 없다. -> private  (시험에 나옴)
            {
                Console.WriteLine("default !");
            }
            private void somePrivate()
            {
                Console.WriteLine("private!");
            }

            // 'Test'를 class에 포함하지 않기 
            public int Multi(int x, int y)
            {
                return x * y;
            }
            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출");
            }
            public int Sum(int min, int max)
            {
                int output = 0;
                for(int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
    }
}
