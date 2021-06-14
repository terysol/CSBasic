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

            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");

            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            // Console.WriteLine(Sample.value);        
            // 메모리 로드 할 때 정적 생성자가 실행이 된다.
            Console.WriteLine("두 번째 위치");
            // 정적 생성자는 두 번째 호출할 때 실행되지 않는다. 
            Console.WriteLine("세 번째 위치");
            // 정적 생성자는 프로그램이 첫 실행될 때 처음만 실행이 된다.
            // 일반 생성자 -> 객체가 생성될 때 실행, 정적생성자 -> 클래스가 메모리에 처음 로드될 때 실행
            // 정적 생성자는 싱글턴 패턴 사용할 때 적합
        }

        class Sample
        {
            public static int value;
            static Sample()     // 매개변수를 가질 수 없다. 
            {
                value = 10;
                Console.WriteLine("정적 생성자 호출");
            }
        }
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = Product.counter + 1;
                this.id = Product.counter;
                this.name = name;
                this.price = price;
            }

            public override string ToString()
            {
                return id + " : " + name;
            }
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
