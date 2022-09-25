using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            A.age = 10;
            A.name = "철수";

            Person B = new Person();
            B.age = 12;
            B.name = "영희";
            A.Say("아 저 이제 10살이에요", B);
            B.Say("저는 12살이에요", A);


            int a = 0;
            float someValue = 1.11f;
            double someValue2 = 1.112d;

           
        }
    }
    class Math
    {
        public const float PI = 3.14f;
    }
    class Person
    {   
        public static int AverageLifeTime = 90; //사람의 평균 수명입니다.

        //생성된 날짜 
        public DateTime date = DateTime.Now;

        public int age;
        public string name;
        public void Say(string something)
        {
            //데이터를 문자열로 표시하는 방법
            //1. string + string = string -> worst case 최악
            Console.WriteLine(name + ": " + something);

            //2. string.Format을 이용하는 방법
            Console.WriteLine(string.Format("{0}: {1}", name, something));

            //3. 가장 좋은 방법 (.net 4.0 이상 지원)
            Console.WriteLine($"{name}({age}) : {something}");
        }


        public void Say(string something, Person other)
        {
            Console.WriteLine($"{name}({age}) : ({other.name}에게) {something}");
        }
    }
}
