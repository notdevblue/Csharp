using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4교시
            //int num = int.Parse(Console.ReadLine());


            //string result = (num % 2) == 0 ? "짝수" : "홀수";
            //Console.WriteLine(result);

            //if (num % 2 != 0)
            //{
            //    result = "홀수";
            //}
            //else
            //{
            //    result = "짝수";
            //}
            //Console.WriteLine(result);


            //int? num = null;
            // ? 넣는 이유: if(num == null) 용도

            // ? = null 인경우 아무것도 안 함
            //ArrayList a = null;
            ////a = new ArrayList();

            //a?.Add("아구"); // null 인 경우 아무것도 안 함
            //a?.Add("축구");
            //Console.WriteLine($"Count : {a?.Count}");
            //Console.WriteLine($"{a?[0]}");
            //Console.WriteLine($"{a?[1]}");

            //string str = null;
            //if (str == null)
            //{
            //    Console.WriteLine("0");
            //}
            //else
            //{
            //    Console.WriteLine($"{str}");
            //}

            //string str1 = null;
            //Console.WriteLine($"{str1 ?? "0"}"); // 만약 null 이면 오른쪽, 아니면 자신 값 사용
            #endregion

            #region 5교시

            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 != 0)
            //{
            //    Console.WriteLine("홀수");
            //}
            //else
            //{
            //    Console.WriteLine("짝수");
            //}

            //int num = int.Parse(Console.ReadLine());

            //if (num < 0)
            //{
            //    Console.WriteLine("음수");
            //}
            //else if (num > 0)
            //{
            //    Console.WriteLine("양수");
            //}
            //else
            //{
            //    Console.WriteLine("0");
            //}

            //int number = int.Parse(Console.ReadLine());

            //if (number <= 0)
            //{
            //    Console.WriteLine("0보다 작거나 같은 수");
            //}
            //else if (number % 2 != 0)
            //{
            //    Console.WriteLine("0보다 큰 홀수");
            //}
            //else
            //{
            //    Console.WriteLine("0보다 큰 짝수");
            //}

            //object obj = null;
            //string s = Console.ReadLine();
            //if (int.TryParse(s, out int out_i))
            //{
            //    obj = out_i;
            //}
            //else if (float.TryParse(s, out float out_f))
            //{
            //    obj = out_f;
            //}
            //else
            //{
            //    obj = s;
            //}

            //switch (obj)
            //{
            //    case int i:
            //        Console.WriteLine($"{i}는 int 형식입니다.");
            //        break;
            //    case float f:
            //        Console.WriteLine($"{f}는 float 형식입니다.");
            //        break;
            //    default:
            //        Console.WriteLine($"{obj}는 모르는 형식입니다.");
            //        break;
            //}
            #endregion

            #region 6교시

            //string str = Console.ReadLine();

            //if(str.Contains("김예리나"))
            //{
            //    Console.WriteLine("와샌즈");
            //}


            //bool state = true;
            //while (state)
            //{
            //    ConsoleKeyInfo info = Console.ReadKey();

            //    switch (info.Key)
            //    {
            //        case ConsoleKey.LeftArrow:
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("왼쪽");
            //            break;
            //        case ConsoleKey.UpArrow:
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("위쪽");
            //            break;
            //        case ConsoleKey.RightArrow:
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //            Console.WriteLine("오른쪽");
            //            break;
            //        case ConsoleKey.DownArrow:
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("아레쪽");
            //            break;
            //        case ConsoleKey.X:
            //            state = false;
            //            break;
            //    }
            //}


            #region 연습문제
            /* 
             * 참, 거짓
             * default
             * Contains();
             
             * O
             * X
             * X
             
             *-2 < x && x <= 3, -2 < x , x >= -20 && x <= 20
             * 3
             * 2
             * 1
             */



            //switch (int.Parse(Console.ReadLine()) % 12)
            //{
            //    case 0:
            //        Console.WriteLine("원숭이");
            //        break;
            //    case 1:
            //        Console.WriteLine("닭");
            //        break;
            //    case 2:
            //        Console.WriteLine("개");
            //        break;
            //    case 3:
            //        Console.WriteLine("돼지");
            //        break;
            //    case 4:
            //        Console.WriteLine("쥐");
            //        break;
            //    case 5:
            //        Console.WriteLine("소");
            //        break;
            //    case 6:
            //        Console.WriteLine("범");
            //        break;
            //    case 7:
            //        Console.WriteLine("토끼");
            //        break;
            //    case 8:
            //        Console.WriteLine("용");
            //        break;
            //    case 9:
            //        Console.WriteLine("뱀");
            //        break;
            //    case 10:
            //        Console.WriteLine("말");
            //        break;
            //    case 11:
            //        Console.WriteLine("양");
            //        break;
            //}

            //string[] ddie = { "원숭이", "닭", "개", "돼지", "쥐", "소", "범", "토끼", "용", "뱀", "말", "양" };
            //Console.WriteLine($"{ddie[int.Parse(Console.ReadLine()) % 12]} 띠");

            //switch ((int.Parse(Console.ReadLine()) - 1) / 3)
            //{
            //    case 0:
            //        Console.WriteLine("봄");
            //        break;
            //    case 1:
            //        Console.WriteLine("여름");
            //        break;
            //    case 2:
            //        Console.WriteLine("가을");
            //        break;
            //    case 3:
            //        Console.WriteLine("겨울");
            //        break;
            //}

            //int x = 12;
            //if(x > 10 && x < 20)
            //{
            //    Console.WriteLine("조건에 맞습니다");
            //}

            /* 10
            (출력 결과 없음)

            x = 10;
            y = 12;
            출력: 120
             */


            //switch (int.Parse(Console.ReadLine()))
            //{
            //    case 1: Console.WriteLine("12학점 필요"); break;
            //    case 2: Console.WriteLine("18학점 필요"); break;
            //    case 3: Console.WriteLine("10학점 필요"); break;
            //    case 4: Console.WriteLine("18학점 필요"); break;
            //    default: break;
            //}
            
            #endregion


            #endregion
        }

    }
}
