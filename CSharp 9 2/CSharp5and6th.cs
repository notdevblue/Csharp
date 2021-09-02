using System;

namespace CSharp5th
{
    class Program
    {
        // class Box
        // {
        //     private int width;
        //     public int Width
        //     {
        //         get { return width; }
        //         set {
        //             if(value > 0) width = value;
        //             else throw new Exception("너비는 자연수를 입력하세요");
        //         }
        //     }

        //     private int height;
        //     public int Height
        //     {
        //         get { return height; }
        //         set {
        //             if(value > 0) height = value;
        //             else throw new Exception("높이는 자연수를 입력하세요.");
        //         }
        //     }

        //     public Box(int width, int height)
        //     {
        //         Width = width;
        //         Height = height;
        //     }

        //     public int Area() { return width * height; }
        // }

        class Player
        {
            public string Nickname { get; set; }
            public int    Level    { get; set; }

            public void LevelUp()
            {
                throw new MyException(@"¯\_(ツ)_/¯") { Nickname = this.Nickname, Level = this.Level};
            }
        }

        class MyException : Exception
        {
            public string Nickname { get; set; }
            public int Level { get; set; }

            public MyException(string msg, Exception e = null) : base(msg)
            {

            }
        }

        static void Main(string[] args)
        {
            Player player1 = new Player() { Nickname = "영웅", Level = 3 };
            Player player2 = new Player() { Nickname = "전사", Level = 1 };
            try
            {
                player1.LevelUp();
            }
            catch(MyException e)
            {
                System.Console.WriteLine("예외가 발생했습니다.");
                System.Console.WriteLine(e.Nickname);
                System.Console.WriteLine(e.Level);

                System.Console.WriteLine();

                System.Console.WriteLine(e.Message);
                System.Console.WriteLine(e.GetType());
                System.Console.WriteLine(e.StackTrace);

                //throw new MyException(":3", e);
            }

            System.Console.WriteLine("wasans");



            // Box box = new Box(-1,10); // Exception

            // System.Console.WriteLine("WA");

            // try
            // {
            //     int a = 1;
            //     System.Console.WriteLine(3 /--a);
            // }
            // catch(DivideByZeroException e)
            // {
            //     System.Console.WriteLine(e.StackTrace);
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

            // try
            // {

            // }
            // catch(Exception e)
            // {

            // }
            // finally // catch 에서 벗어날 때 실행이 되는 구간 (반드시 실행이 됨, 리턴을 만나도)
            // {

            // }

            // try
            // {

            // }
            // finally // catch 생략 가능
            // {

            // }

            // int a = 0;
            // System.Console.WriteLine("입력: ");
            // string input = Console.ReadLine();

            // try
            // {
            //     ++a;
            //     int idx = int.Parse(input);
            //     System.Console.WriteLine("입력 숫자: " + idx);
            // }
            // catch (Exception e)
            // {
            //     ++a;
            //     System.Console.WriteLine("예외가 발생했습니다.");
            //     System.Console.WriteLine(e.GetType());

            //     System.Console.WriteLine("A : " + a);
            //     // return 해도 finally 가 실행이 됨
            //     // 하지만 return value 를 하면 value 는 고정됨
            // }
            // finally
            // {
            //     ++a;
            //     System.Console.WriteLine("프로그램이 종료되었습니다.");
            // }

            // System.Console.WriteLine(a);

            // System.Console.WriteLine("입력: ");
            // string input = Console.ReadLine();

            // try
            // {
            //     int idx = int.Parse(input);
            //     System.Console.WriteLine("입력 숫자 : " + idx);
            // }
            // catch(NullReferenceException e)
            // {
            //     System.Console.WriteLine("오 이런.");
            // }
            // catch(ArgumentOutOfRangeException e)
            // {
            //     System.Console.WriteLine("크다.");
            // }
            // catch(Exception e)
            // {
            //     System.Console.WriteLine(e.Message);
            //     System.Console.WriteLine(e.StackTrace);
            // }

            // try
            // {
            //     throw new Exception();
            // }
            // catch(Exception e)
            // {
            //     System.Console.WriteLine("예외");
            //     System.Console.WriteLine(e.Message);
            //     System.Console.WriteLine(e.GetType());
            // }
        }
    }
}