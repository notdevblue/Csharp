using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_9_2
{
    class Program
    {
        // class Member
        // {
        //     public string Name { get; set; }
        //     public string Addr { get; set; }
        //     public Member(string name, string addr)
        //     {
        //         this.Name = name; this.Addr = addr;
        //     }

        //     // public int CompareTo(object obj)
        //     // {
        //     //     return this.Name.CompareTo((obj as Member).Name);
        //     // }
        // }

        // class Comparer : IComparer
        // {
        //     public int Compare(object x, object y)
        //     {
        //         return (x as Member).Name.CompareTo((y as Member).Name);
        //     }
        // }

        // static public int CompareTo(object obj1, object obj2)
        // {
        //     return (obj1 as Member).Name.CompareTo((obj2 as Member).Name);
        // }



        static void Main2(string[] args)
        {
            // Member[] members = new Member[3];
            // members[0] = new Member("홍길동", "율도국");
            // members[1] = new Member("강감찬", "대한민국");
            // members[2] = new Member("이순신", "한산도");

            // // foreach (var item in members)
            // // {
            // //     System.Console.WriteLine(item.Name);
            // //     System.Console.WriteLine(item.Addr);
            // //     System.Console.WriteLine();
            // // }

            // Comparer compare = new Comparer();

            // Array.Sort(members, compare);
            
            // foreach (var item in members)
            // {
            //     System.Console.WriteLine(item.Name);
            //     System.Console.WriteLine(item.Addr);
            //     System.Console.WriteLine();
            // }

            // string[] arr = {"가","나"};
            // System.Console.WriteLine("숫자를 입력해주세요.");

            // bool isOK = int.TryParse(Console.ReadLine(), out int input); // 0, 1
            // if(!isOK)
            // {
            //     System.Console.WriteLine("숫자가 아닙니다.");
            // }
            // else if(input < 0 || input > 1)
            // {
            //     System.Console.WriteLine("array 의 크기를 벗어났습니다.");
            // }
            // else
            // {
            //     System.Console.WriteLine("입력위치의 값은 " + arr[input] + " 입니다.");
            // }

            // string[] arr ={"가", "나"};
            // System.Console.WriteLine("숫자를 입력해주세요");

            // try
            // {
            //     int input = int.Parse(Console.ReadLine());
            //     System.Console.WriteLine("입력위치의 값은 " + arr[input] + " 입니다.");
            // }
            // catch(Exception e)
            // {
            //     System.Console.WriteLine("예외가 발생했어요.");
            //     System.Console.WriteLine(e.Message); // 예외의 내용을 출력. e 는 예외 전체가 나온다. 흠흠
            //     System.Console.WriteLine(e.StackTrace); // 경로를 추적함 
            // }

        }
    }
}
