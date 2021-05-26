using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
    class MyMath
    {
        public int a;
        public static double PI = 3.141592;
        public static void Hello()
        {
            // a = 3; 접근 안됨
            Console.WriteLine("Greeting~");
        }
    }
    class Product
    {
        public string name = "defalut";
        public int price = 1000;

        public override string ToString()
        {
            return this.name + " / " + this.price; 
        }
    }
    class Car
    {
        // C# 기본세팅은 private
        int carNumber;
        DateTime inTime;
        DateTime outTime;
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));        // 0 ~ 99 
            Console.WriteLine(random.Next(10,000));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*100);

            List<int> list=new List<int>();
            list.Add(52);
            list.Add(245);
            list.Add(123);
            list.Add(56);
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titme : " + item);
                // list.Remove(item);   list가 바뀌지 않을 가정하에 foreach문을 돌린다. 
            }
            list.Remove(52);
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titme : " + item);
            }

            Console.WriteLine(Math.Abs(-2345));
            Console.WriteLine(Math.Ceiling(89.343));
            Console.WriteLine(Math.Floor(89.343));
            Console.WriteLine(Math.Max(45,78));
            Console.WriteLine(Math.Min(45,78));
            Console.WriteLine(Math.Round(45.78));

            Product product = new Product();
            Console.WriteLine(product);
            Product productA = new Product() { name="감자",price=2000};
            Console.WriteLine(productA.ToString());
            Product productB = new Product() { name="고구마",price=3000};
            Console.WriteLine(productB.ToString());        // product라고 만 나옴.

            Console.WriteLine(MyMath.PI);
            MyMath.Hello();

            /*
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "윤인성", grade = 1 });
            students.Add(new Student() { name = "연하진", grade = 2 });
            students.Add(new Student() { name = "윤아린", grade = 4 });
            students.Add(new Student() { name = "사람", grade = 1 });
            students.Add(new Student() { name = "기본", grade = 2 });
            students.Add(new Student() { name = "김솔민", favorityFood="치킨" });
            */
            List<Student> students = new List<Student>() {
                new Student() { name = "윤인성", grade = 1 },
                new Student() { name = "연하진", grade = 2 },
                new Student() { name = "윤아린", grade = 4 },
                new Student() { name = "사람", grade = 1 },
                new Student() { name = "기본", grade = 2 },
                new Student() { name = "김솔민", favorityFood = "치킨" },
        };
        }
    }
    
    class FirstClass
    {

    } 
    class SecondClass
    {
        class ChildClass
        {

        }
    }
}
