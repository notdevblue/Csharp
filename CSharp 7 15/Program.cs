using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp_7_15
{
    class Program
    {
        #region 4교시

        //interface I_Item
        //{
        //    void LevelUp();
        //    void Reinforce();
        //}

        //public interface IComparable
        //{
        //    int CompareTo(object obj);
        //}

        //class MyClass : IComparable
        //{

        //}

        //interface IRunnable
        //{
        //    void Run();
        //}

        //interface IFlyable
        //{
        //    void Fly();
        //}

        //class FlyingCar : IRunnable, IFlyable
        //{
        //    public void Run()
        //    {
        //        Console.WriteLine("Run! Run!");
        //    }

        //    public void Fly()
        //    {
        //        Console.WriteLine("Fly! Fly!");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    FlyingCar car = new FlyingCar();
        //    car.Run();
        //    car.Fly();

        //    IRunnable runnable = car as IRunnable;
        //    runnable.Run();

        //    IFlyable flyable = car as IFlyable;
        //    flyable.Fly();
        //}

        /*  
    public interface IComparable
    {        
        int CompareTo(object obj);  // 멤버 앞에 접근제한자 사용 안함
    }
*/

        //class MyClass : IComparable
        //{
        //    private int key;
        //    private int value;
        //    public MyClass(int a) { key = a; }

        //    // IComparable 의 CompareTo 메서드 구현
        //    public int CompareTo(object obj)
        //    {
        //        MyClass target = (MyClass)obj;
        //        return this.key.CompareTo(target.key);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    MyClass mc1 = new MyClass(1);
        //    MyClass mc2 = new MyClass(2);

        //    Console.WriteLine(mc1.CompareTo(mc2));
        //    Console.WriteLine(mc2.CompareTo(mc1));
        //}


        #region Dispose();
        //class Dummy : IDisposable
        //{
        //    // 리소스 해제하는 함수
        //    public void Dispose()
        //    {
        //        // 명시적으로 가비지컬랙터 호출 할 수 있음
        //        Console.WriteLine("Disopose()");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Dummy a = new Dummy();
        //    a.Dispose();

        //    // RAII 패턴 비슷한 느낌
        //    // 정상 완료 또는 에러 발생 시 Dispose 부름
        //    // Dispose 불러야 하면 꼭 using 사용해야 할 듯 하다.
        //    // 또는 try, catch
        //    using (Dummy b = new Dummy())
        //    {
        //        // 알아서 Dispose();
        //    }

        //}
        #endregion // Dispose();

        #endregion
        #region 5교시

        //class BirthdayInfo
        //{
        //    public string Name { get; set; } = "Unknown";
        //    public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        //    public int Age
        //    {
        //        get
        //        {
        //            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
        //        }
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    BirthdayInfo b = new BirthdayInfo() { Name = "Han", Birthday = new DateTime(1, 1, 1) };
        //}


        #region 익명 타입


        //static void Main(string[] args)
        //{
        //    // 웹소켓 할때 편할수도
        //    var a = new { Name = "한우엽", Age = 18 };

        //    Console.WriteLine("Name:{0}, Age:{1}", a.Name, a.Age);


        //}
        //static void Main(string[] args)
        //{
        //    var a = new { Name = "홍길동", Age = 123 };
        //    Console.WriteLine("Name:{0}, Age:{1}", a.Name, a.Age);

        //    var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

        //    Console.Write("Subject:{0}, Scores: ", b.Subject);
        //    foreach (var score in b.Scores)
        //        Console.Write("{0} ", score);

        //    Console.WriteLine();

        //    var c = new
        //    {
        //        new { Age = 123123, Id = 11},
        //        new { Age = 123123, Id = 11},
        //        new { Age = 123123, Id = 11},
        //        new { Age = 123123, Id = 11},
        //        new { Age = 123123, Id = 11},
        //        new { Age = 123123, Id = 11},
        //    };
        //}

        //interface INameValue
        //{
        //    string NameValue { get; set; }
        //}

        //class NameVal : INameValue
        //{
        //    public string NameValue { get; set; }
        //}

        #endregion

        #endregion
        #region 5교시 Collections

        //static void Main(string[] args)
        //{
        //    string[] arr1 = new string[3] { "1", "2", "3" };
        //    string[] arr2 = new string[] { "1", "2", "3" };
        //    string[] arr3 = { "1", "2", "3" };


        //    int[,] arr2D = new int[2, 3];
        //    // ㅁ ㅁ ㅁ
        //    // ㅁ ㅁ ㅁ

        //    // int 배열이 3개 있다는 의미
        //    int[][] jagged = new int[3][];

        //    jagged[0] = new int[2];
        //    jagged[1] = new int[5];
        //    jagged[2] = new int[4];

        //    int[][] jagged2 = new int[2][] { new int[2], new int[4] };
        //}

        //static void Main(string[] args)
        //{
        //    int[][] jagged = new int[3][];
        //    jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
        //    jagged[1] = new int[] { 10, 20, 30 };
        //    jagged[2] = new int[] { 100, 200 };


        //    foreach (int[] arr in jagged)
        //    {
        //        Console.Write($"Length : {arr.Length}, ");
        //        foreach (int e in arr)
        //        {
        //            Console.Write($"{e} ");
        //        }


        //        foreach (int[] arr2 in jagged)
        //        {
        //            Console.Write($"Length : {arr.Length}, ");
        //            foreach (int e in arr)
        //            {
        //                Console.Write($"{e} ");
        //            }
        //            Console.WriteLine("");
        //        }
        //        Console.WriteLine("");

        //        int[][] jagged2 = new int[2][] {
        //        new int[] { 1000, 2000 },
        //        new int[4] { 6, 7, 8, 9 } };

        //        foreach (int[] arr2 in jagged2)
        //        {
        //            Console.Write($"Length : {arr.Length}, ");
        //            foreach (int e in arr)
        //            {
        //                Console.Write($"{e} ");
        //            }
        //            Console.WriteLine();
        //        }


        //    }
        //}

        #endregion
        #region 6교시


        //class A
        //{
        //    // 읽기 전용 프로퍼티
        //    // C# 6.0 의 Expression-bodied member 표현
        //    public string Disc => "wasans";
        //    // Disc 접근하면 "wasans" 리턴


        //    //public int Get12() => new int() {};
        //    public void Print() => Console.WriteLine("Data");
        //    //public void Print()
        //    //{
        //    //    Console.WriteLine("Data");
        //    //}
        //}

        //static void Main(string[] args)
        //{
        //    int[] arr = { 123, 456, 789 };
        //    ArrayList list = new ArrayList(arr) { [1] = 333 };

        //    Hashtable ht2 = new Hashtable()
        //    {
        //        ["하나"] = "one"
        //    };
        //}

        //static IEnumerable<int> GetNumber()
        //{
        //    yield return 10;
        //    yield return 20;
        //    yield return 30;
        //}

        //class A
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6 };
        //    public IEnumerator GetEnumerator()
        //    {
        //        yield return numbers[0];
        //        yield return numbers[1];
        //        yield return numbers[2];
        //        yield return numbers[3];
        //        Console.WriteLine("Exitting");

        //        yield break;
        //        yield return numbers[4];
        //        yield return numbers[5];
        //    }
        //}

        //class MyEnumerator
        //{
        //    int[] numbers = { 1, 2, 3, 4 };
        //    public IEnumerator GetEnumerator()
        //    {
        //        yield return numbers[0];
        //        yield return numbers[1];
        //        yield return numbers[2];
        //        yield break;
        //        yield return numbers[3];
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    //foreach (int item in GetNumber())
        //    //{
        //    //    Console.WriteLine(item);
        //    //}

        //    //var obj = new MyEnumerator();
        //    //foreach (int i in obj)
        //    //    Console.WriteLine(i);

        //    A a = new A();
        //    foreach (var item in a)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


        static void Main(string[] args)
        {
            //string ss = string.Empty;
            //for (int i = 0; i <= 100000; ++i)
            //{
            //    ss += i.ToString();
            //}
            //Console.WriteLine(ss);

            // 이거다.
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= 100000; ++i)
            {
                sb.Append(i);
            }

            string s = sb.ToString();

            Console.WriteLine(s);
        }

        #endregion
    }
}
