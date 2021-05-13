using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_5_13
{
    class Program
    {
        #region 4교시

        //class Box
        //{
        //    public int Width { get; set; }
        //    public int Height { get; set; }
        //}

        //class CTest
        //{
        //    public int a;
        //}

        //static void Method(CTest a)
        //{
        //    a.a = 2;
        //}
        //static void Method1(int a)
        //{
        //    a = 2;
        //}
        #endregion

        #region 5, 6교시

        //class Fibonacci
        //{
        //    private static Dictionary<int, ulong> memo = new Dictionary<int, ulong>();

        //    public static ulong Get(int i)
        //    {
        //        if (i < 0) { return 0; }
        //        if (i == 1) { return 1; }

        //        if(memo.ContainsKey(i))
        //        {
        //            return memo[i];
        //        }
        //        else
        //        {
        //            ulong value = Get(i - 2) + Get(i - 1);
        //            memo[i] = value;
        //            return value;
        //        }

        //    }
        //}

        //class Animal
        //{
        //    public Animal() { this.Age = 0; }
        //    protected int Age { get; set; }
        //    public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        //    public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
        //}

        //class Dog : Animal
        //{
        //    public string Color { get; set; }
        //    public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
        //}

        //class Cat : Animal
        //{
        //    public void Meow() { Console.WriteLine("냥냥 웁니다."); }
        //}

        //class Parent
        //{
        //    public Parent() { Console.WriteLine("부모 생성자"); }
        //    public Parent(int param) { Console.WriteLine("부모 생성자 " + param); }
        //    public Parent(string param) { Console.WriteLine("부모 생성자 " + param); }
        //}
        //class Child : Parent
        //{
        //    public Child() : base() { Console.WriteLine("자식 생성자"); }
        //    public Child(int input) : base(input) { Console.WriteLine("자식 생성자 " + input); }
        //    public Child(string input) : base(input) { Console.WriteLine("자식 생성자 " + input); }
        //}

        class Parent
        {
            public static int counter = 0;
            public void CountParent()
            {
                ++Parent.counter;
            }
        }
        class Child : Parent
        {
            public void CountChild()
            {
                ++Child.counter;
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region 4교시

            //Box box = new Box();
            //box.Width = 10;
            //box.Height = 154;
            //Console.WriteLine(box.Width);
            //Console.WriteLine(box.Height);

            //int a = 0;
            //int b = a;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //CTest c1 = new CTest();
            //CTest c2 = new CTest();
            //c2.a = c1.a;

            //c1.a = 10;
            //Console.WriteLine($"c1: {c1.a}");
            //Console.WriteLine($"c2: {c2.a}");
            //c2.a = 154;

            //Console.WriteLine($"c1: {c1.a}");
            //Console.WriteLine($"c2: {c2.a}");

            //int a = 0;
            //CTest c1 = new CTest();
            //Method(c1);
            //Method1(a);
            //Console.WriteLine(c1.a);
            //Console.WriteLine(a);



            #endregion

            #region 5, 6교시

            //Fibonacci fibo = new Fibonacci();
            //Console.WriteLine(Fibonacci.Get(13360));
            //Console.WriteLine(Fibonacci.Get(13500));
            //Console.WriteLine(Fibonacci.Get(5555));
            //Console.WriteLine(Fibonacci.Get(10000));
            //Console.WriteLine(Fibonacci.Get(13000));

            #region 연습문제

            /* 1번
             * X
             * X
             * X
             * X
             * X
             * X
             * O
             * X
             * 
             */

            /* 2
             * 4번
             */

            /* 3
             * 안되는거
             * 1번
             * 4번
             * 
             * 되는거
             * 2번
             * 3번
             */


            /* 4
             * 2번
             */

            /* 5
             * 4번
             */

            /* 6
             * 
             * 10
             * 40
             */

            /* 7
             * 
             * A의 생성자
             * B의 생성자
             * B의 소멸자
             * A의 소멸자
             * 
             */

            /* 8
             * 
             * 컴파일 에러
             * 
             */


            #endregion


            //List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            //List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            //foreach(var item in Dogs)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Bark();
            //}

            //foreach (var item in Cats)
            //{
            //    item.Eat();
            //    item.Sleep();
            //    item.Meow();
            //}

            //List < Animal > Animals = new List<Animal>() { new Dog(), new Dog(), new Cat() };
            //foreach (var item in Animals)
            //{
            //    item.Eat();
            //    item.Sleep();

            //    if (item is Dog)
            //    {
            //        (item as Dog).Bark();
            //    }
            //    else if(item is Cat)
            //    { 
            //        (item as Cat).Meow();    
            //    }

            //    //switch (item)
            //    //{
            //    //    case Dog _:
            //    //        ((Dog)item).Bark();
            //    //        break;
            //    //    case Cat _:
            //    //        ((Cat)item).Meow();
            //    //        break;
            //    //}
            //}

            //Animal a = new Dog();
            //((Dog)a).Bark();

            //List<Object> listOfObject = new List<Object>();
            //listOfObject.Add(new Dog());
            //listOfObject.Add(new Cat());
            //listOfObject.Add(52);
            //listOfObject.Add(52L);
            //listOfObject.Add(52.273f);
            //listOfObject.Add(52.273);

            //Child child = new Child();

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountParent();
            
            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);

            #endregion
        }
    }
}
