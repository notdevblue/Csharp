using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_4_15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4교시 였던 것
            //int cnt = 0;
            //for(char i = '가'; i < '힣'; ++i)
            //{
            //    ++cnt;
            //    Console.Write(i);
            //}
            //Console.Write(cnt);

            //long start = DateTime.Now.Ticks;
            //long count = 0;

            //while(start + 10000000 > DateTime.Now.Ticks)
            //{
            //    ++count;
            //}
            //Console.WriteLine(count);

            //int[] array = { 1, 2, 3, 4, 5 };
            //string[] fruit = { "사과", "배", "딸기", "포도", "바나나" };

            //for (int i = 0; i < array.Length; ++i)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //for (int i = array.Length - 1; i >= 0; --i)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in fruit)
            //{
            //    Console.WriteLine(item);
            //}

            //int line = 10;

            //for(int i = 0; i < line; ++i)
            //{
            //    for(int k = 0; k <= i; ++k)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\r\n");
            //}

            //for(int i = 0; i < line; ++i)
            //{
            //    for(int k = line - 1; k > i; --k)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 0; k <= i; ++k)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\r\n");
            //}

            //for (int i = 0; i < line; ++i)
            //{
            //    for (int k = line - 1; k > i; --k)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k <= i * 2; ++k)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\r\n");
            //}
            //for (int i = 0; i < line; ++i)
            //{
            //    for (int k = 0; k <= i; ++k)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < (line - i - 1) * 2; ++k)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\r\n");
            //}

            //for(int i = 0; i < 5; ++i)
            //{
            //    if (i == 2) continue;
            //    if (i == 4) break;
            //    Console.WriteLine(i);
            //}

            //bool stop = false;
            //for(int i = 0; i < 100; ++i)
            //{
            //    for(int j = 0; j < 100; ++j)
            //    {
            //        if (i == 50 && j == 50)
            //        {
            //            //i = 100;
            //            //break;
            //            stop = true;
            //            break;
            //        }
            //    }
            //    if(stop) { break; }
            //}

            //string upper = "wasans";
            //string lower = "WASANS";

            //string input = "얘, 봄감자가 맛있단다.";
            //string[] inputs = input.Split(',',' ');

            //foreach(var item in inputs)
            //{
            //    Console.WriteLine(item);
            //}

            //string input = "        hello       \n";
            //Console.WriteLine("::" + input.Trim() + "::");

            //string[] array = { "와", "샌즈", "아시는구나" };
            //Console.WriteLine(string.Join("!", array));


            //int x = 1;
            //while(x < 50)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 5);

            //    if (x % 3 == 0)
            //        Console.Write("__@");
            //    else if (x % 3 == 1)
            //        Console.Write("_^@");
            //    else
            //        Console.Write("^_@");

            //    Thread.Sleep(150);
            //    ++x;
            //}

            /* 1
             1:요소
             2:인덱스
             3:Length
             4:break
             5:continue
             6:비 파괴(choi) 적
             */

            /* 2
             * 2
             */

            /* 3
             * 2
             */

            /* 4
             * 3
             */

            /* 5
             * 2
             */

            /* 6
             * 2
             */

            /* 7
             * 2
             */

            /* 8
             * 0 열번 출력 (new int[] => 0 초기화아)
             */

            /* 9
             * 출력 을 10번 출력 *잘못봄*
             */

            // 10
            //int ai = 0;
            //while (ai < 10) { Console.WriteLine("출력"); ++ai; }

            //// 11
            //for (int i = 0; i < line; ++i)
            //{
            //    for (int k = line - 1; k > i; --k)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k <= i * 2; ++k)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\r\n");
            //}

            //// 12

            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    Console.Write("숫자를 입력해주세요: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = int.MinValue;
            //int min = int.MaxValue;
            //foreach(var item in arr)
            //{
            //    if (item > max)
            //        max = item;
            //    if (item < min)
            //        min = item;
            //}
            //Console.WriteLine($"가장 큰 수: {max}");
            //Console.WriteLine($"가장 작은 수: {min}");

            //// 13

            // 1
            // 1 이 1
            // 1 이 2
            // 1 이 1 2 이 1
            // 1 이 2 2 이 1 1 이 1

            //string[] str = new string[1024];
            //str[0] = "1";


            //string strr = "1";
            //string newstr = "";
            //char num = strr[0];

            //for (int k = 0; k < 20; ++k)
            //{
            //    int count = 1;
            //    for (int i = 1; i < strr.Length; ++i)
            //    {
            //        if (strr[i] == num)
            //        {
            //            ++count;
            //        }
            //        else
            //        {
            //            newstr += num + count.ToString();
            //            count = 1;
            //            num = strr[i];
            //        }
            //    }
            //    newstr += num + count.ToString();
            //}

            //Console.WriteLine(newstr);

            //for(int k = 0; k < 20; ++k)
            //{
            //    int count = 0;
            //    for (int i = 1; i < str.Length - 1; ++i)
            //    {
            //        if (str[i - 1] == str[i])
            //        {
            //            ++count;
            //        }

            //        if (str[i] == null)
            //        {
            //            str[i - 1] = count.ToString();
            //            break;
            //        }
            //    }
            //}

            //foreach(var item in str)
            //{
            //    Console.Write(item);
            //}

            //// 돌아가는 코드
            //string str = "1";
            //for (int i = 0; i < 20; ++i)
            //{
            //    Console.WriteLine($"{i + 1}번째: {str}");

            //    string end = "";
            //    char number = str[0]; // 초기값 숫자
            //    int count = 0; // 초기값 갯수

            //    for (int j = 0; j < str.Length; ++j)
            //    {
            //        if (number == str[j])
            //        {
            //            ++count; // 같으면 카운트
            //        }
            //        else
            //        {
            //            end = end + number + count; // 아니면 기록 number + count
            //            number = str[j]; // 초기값 숫자
            //            count = 1; // 초기값 갯수
            //        }
            //    }
            //    end = end + number + count; // 끝나면 기록

            //    str = end; // 다음 단계 준비
            //}

            //for(int i = 2; i <= 9; ++i)
            //{
            //    for(int j = 1; j <= 9; ++j)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //    }
            //}

            //List<int> list = new List<int>();
            //for(int i = 0; i < 5; ++i)
            //{
            //    list.Add(i);
            //}

            //foreach(var item in list)
            //{
            //    Console.Write(item + ",");
            //}


            //int count = 0;
            //for(int i = 1; i<= 1000; ++i)
            //{
            //    if (i % 50 == 0)
            //        ++count;
            //}
            //Console.WriteLine(count);

            //string str = "감자 고구마 토마토";
            //string[] strarr = str.Split(' ');

            //string str2 = "고구마 토마토";
            //string str3 = "";
            //for(int i = str2.Length - 1; i >= 0; --i)
            //{
            //    str3 += str2[i];
            //    Console.Write(str2[i]);
            //}
            //Console.Write("\r\n" + str3);


            string input;
            string id = "";
            bool isOK = false;
            while(!isOK)
            {
                id = "";
                input = Console.ReadLine();
                id = input.ToLower();
                for(int i = 0; i < input.Length; ++i)
                {
                    if (input[i] < 'a' || input[i] > 'z')
                    {
                        Console.WriteLine("아이디는 영어여야만 합니다.");
                        break;
                    }
                    else
                    {
                        id = input;
                        isOK = true;
                    }
                }
            }

            Console.WriteLine(id);
            #endregion
        }
    }
}
