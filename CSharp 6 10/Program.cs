// 20219 한우엽

using System;
using System.Collections.Generic;
namespace CSharp_6_10
{
    //interface IBase
    //{
    //    void Message();
    //}
    //
    //class Drived : IBase
    //{
    //    public void Message()
    //    {
    //        Console.WriteLine("Packet Arrived");
    //    }
    //}


    class Program
    {
        #region 5교시

        //class Item : IComparable
        //{
        //    public int id = -1;
        //    public Item(int id) { this.id = id; }

        //    //public int CompareTo(object obj)
        //    //{
        //    //    return obj;
        //    //}
        //}

        //struct Point
        //{
        //    public int x;
        //    public int y;

        //    public Point(int a, int b)
        //    {
        //        x = a;
        //        y = b;
        //    }
        //}
        // struct = 값
        // Class = 참조

        //class PC
        //{
        //    public int x;
        //    public int y;
        //    public PC(int x, int y) { this.x = x; this.y = y; }
        //}

        //struct PS
        //{
        //    public int x;
        //    public int y;
        //    public PS(int x, int y) { this.x = x; this.y = y; }
        //}
        #endregion

        #region 6교시

        //static void Swap(ref int a, ref int b)
        //{
        //    int tmp = a;
        //    a = b;
        //    b = tmp;
        //}

        //class SC
        //{
        //    public int someValue = 10;
        //    public ref int SomeMethod()
        //    {
        //        return ref someValue;
        //    }
        //}

        //public static void Dev1(int a, int b, ref int q, ref int r)
        //{
        //    q = a / b; r = a % b;
        //}
        //public static void Dev2(int a, int b, out int q, out int r)
        //{
        //    q = a / b; r = a % b;
        //}

        // params 배열 = 가변으로 받을 수 있게 됨
        //public static int Sum(params int[] args)
        //{
        //    int sum = 0;

        //    for(int i = 0; i < args.Length; ++i)
        //    {
        //        sum += args[i];
        //    }

        //    return sum;
        //}

        //public static void Print(string name, string phone)
        //{
        //    Console.WriteLine(name + " " + phone);
        //}
        //static void Foo()
        //{
        //    Console.WriteLine("");
        //}
        //static void Foo(int a = 0)
        //{
        //    Console.WriteLine(a);
        //}

        //static public void Foo() // 메소드
        //{
        //    int count = 0;

        //    Goo(1, 2);
        //    Goo(3, 4);

        //    void Goo(int a, int b) // 로컬 함수
        //    {
        //        Console.WriteLine("{0}", ++count);

        //        Duck();

        //        void Duck() // 로컬 함수
        //        {
        //            Console.WriteLine("ori");
        //        }
        //    }
        //}

        static public void Prn(int a)
        {
            Console.WriteLine(a);
        }

        delegate void MyDel(int a);

        static public void Foo()
        {
            
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        delegate void Del(int a, int b);

        #endregion

        static void Main(string[] args)
        {
            #region 5교시

            #region Sort


            //Drived d = new Drived();
            //d.Message();

            //List<string> myList = new List<string>();

            //myList.Add("Naver");
            //myList.Add("Kakao");
            //myList.Add("Apple");
            //myList.Add("Steam");
            //myList.Add("Daum");

            //List<Item> myItem = new List<Item>();

            //myItem.Add(new Item(664311231));
            //myItem.Add(new Item(121235167));
            //myItem.Add(new Item(633466433));
            //myItem.Add(new Item(145266342));
            //myItem.Add(new Item(156256456));
            //myItem.Add(new Item(122434446));

            ////myList.Sort(Compare);
            ////myList.Sort(new StringCompare());

            ////myList.Sort((x, y) => x.CompareTo(y));
            //myList.Sort((x, y) => y.CompareTo(x));
            ////myItem.Sort((x, y) => x.id.CompareTo(y.id));
            //myItem.Sort((x, y) => y.id.CompareTo(x.id));


            //foreach(string item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (Item item in myItem)
            //{
            //    Console.WriteLine(item.id);
            //}

            #endregion

            //Point p = new Point();

            //p.x = 10;
            //p.y = 15;

            //DataTime d = new DateTime(2021, 11, 1);

            //PC pA = new PC(10, 20);
            //PC pB = pA;
            //pA.x = 200;
            //pA.y = 200;
            //Console.WriteLine(pB.x + " " + pB.y);

            //PS sA = new PS(10, 20);
            //PS sB = sA;
            //sA.x = 200;
            //sA.y = 200;
            //Console.WriteLine(sB.x + " " + sB.y);

            #region 연습문제

            /* 1
             * X
             * X
             * X
             * O
             * O
             */

            /* 2
             * O
             * X
             * O
             * O
             */

            /* 3
             * O
             * X
             * X
             * X
             */

            /* 4
             * O
             * X
             * O
             * O
             */
            #endregion
            #endregion

            #region 6교시

            //int a = 10;
            //int b = 4;
            //Swap(ref a, ref b);

            //Console.WriteLine(a + " " + b);

            //SC a = new SC();
            //int r1 = a.SomeMethod(); // 별도로 r1 에 값 넣음
            //ref int r2 = ref a.SomeMethod(); // 참조함

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //a.someValue = 20;
            //Console.WriteLine(r2);

            //int a = 0;
            //int b = 0;

            //Dev1(10, 3, ref a, ref b);
            //Dev2(10, 3, out int x, out int y);
            //Console.WriteLine(x + " " + y);

            //int total = Sum(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);


            //Print(name: "홍길동", phone: "010-2754-4749"); // 출력 같음
            //Print(phone: "010-2754-4749", name: "홍길동"); // 출력 같음

            //Console.WriteLine("{0}, {1}, {2}, {3}", 1, 2, 3, 4);

            //Foo();
            //Foo(1);

            //Foo();

            MyDel myd = new MyDel(Prn); // <= Task와 같은 듯 함

            myd(1);

            M(myd); // <= 함수 포인터처럼 사용할 수 있을 듯 함


            Del d = new Del(Add);

            //Del[] darr = new Del[3];
            


            d(10, 10);

            #endregion
        }

        static void M(MyDel myd)
        {
            myd(123);
        }

        #region 5교시

        //static public int Compare(string x, string y)
        //{
        //    return x.CompareTo(y);
        //}

        //public class StringCompare : IComparer<string>
        //{
        //    public int Compare(string a, string b)
        //    {
        //        return a.CompareTo(b);
        //    }
        //}
        #endregion

    }
}
