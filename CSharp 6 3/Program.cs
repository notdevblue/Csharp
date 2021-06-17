using System;


// 6교시만 있음
namespace CSharp_6_3
{
    class Program
    {
        //class MyClass<T> where T : struct
        //{
        //    public T value;
        //    public MyClass(T value)
        //    {
        //        this.value = value;
        //    }
        //    //public void Foo<T1>() { }
        //}

        //class SquareCalculator
        //{
        //    public int this[int i] // this[] <= 인덱서
        //    {
        //        get
        //        {
        //            return i * i;
        //        }
        //        set
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //public string this[string i] // <= string 해도 됨
        //{
        //    get { return i; }
        //    set { Console.WriteLine(i + " 번째 상품 설정, " + value); }
        //}

        //class MyList
        //{
        //    private int[] array;
        //    public MyList() { array = new int[5]; }
        //    public int this[int index]
        //    {
        //        get { return array[index]; }
        //        set
        //        {
        //            if (index >= array.Length) return;
        //            array[index] = value;
        //        }
        //    }
        //    public int Length { get { return array.Length; } }
        //}

        static void Div(int a, int b, out int ans, out int leftover)
        {
            ans = a / b;
            leftover = a % b;
        }

        static void Main(string[] args)
        {
            //MyClass<int>     myClass  = new MyClass<int>(1);
            ////MyClass<string>  myClass1 = new MyClass<string>("asdad");
            //MyClass<decimal> myClass2 = new MyClass<decimal>(3.0m);
            //MyClass<float>   myClass3 = new MyClass<float>(34.23f);
            ////MyClass<Program> myClass4 = new MyClass<Program>(new Program());

            //SquareCalculator calc = new SquareCalculator();
            //Console.WriteLine(calc[10]);

            //calc[1] = 0;


            //Program p = new Program();
            //p[1] = 2;
            //Console.WriteLine(p[20]);


            //p["와센즈"] = "";
            //Console.WriteLine(p["우앱"]);

            //MyList list = new MyList();
            //for (int i = 0; i < 5; ++i) list[i] = i;
            //for (int i = 0; i < list.Length; ++i) Console.WriteLine(list[i]);

            //int output;
            //bool result = int.TryParse(Console.ReadLine(), out output);

            //if(result)
            //{
            //    Console.WriteLine("입력한 숫자: " + output);
            //}
            //else
            //{
            //    Console.WriteLine("숫자를 입력해주세요!");
            //}

            int x;
            int y;
            Div(10, 3, out x, out y);

            Console.WriteLine($"목: {x} 나머지: {y}");
        }
    }
}
