using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPrepare
{
    //class Car
    //{
    //    public int carNumber;
    //    int inTime;
    //    int outTime;
    //    public void SetInTime(int a)
    //    {
    //        inTime = a;
    //    }
    //}
 
    class Program
    {
        static void Main(string[] args)
        {
            #region 연습문제
            #region 1번
            //int grade = int.Parse(Console.ReadLine());
            //switch (grade)
            //{
            //    case 1:
            //        Console.WriteLine("Excellent");
            //        break;
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Great");
            //        break;
            //    default:
            //        Console.WriteLine("Good");
            //        break;
            //}
            #endregion
            #region 2번
            //int input = 1;
            //while(input != 0)
            //{
            //    input = int.Parse(Console.ReadLine());
            //}
            #endregion
            #region 3번
            //for(int i = 1; i < 11; ++i)
            //{
            //    if (i % 2 != 0)
            //        continue;
            //    Console.WriteLine(i);
            //}
            #endregion
            #region 4번
            //int count = 0;
            //for(int i = 0; i <= 100; ++i)
            //{
            //    if (i % 4 == 0 && i % 5 == 0)
            //        ++count;
            //}
            //Console.WriteLine(count);
            #endregion
            #region 5번
            //string[] strarr = { "감자", "고구마", "토마토" };
            //foreach(var item in strarr) // 손코딩할때 var 빼먹엇
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region  6번
            //string str = "고구마 토마토";
            //for(int i = str.Length - 1; i >= 0; --i)
            //{
            //    Console.Write(str[i]);
            //}
            #endregion
            #region 7번
            //List<string> list = new List<string>();
            //while(true)
            //{
            //    list.Add(Console.ReadLine());
            //    list.Sort();
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion // 다음에
            #region 8번
            //bool isOK = false;
            //while(!isOK)
            //{
            //    bool isLengthOK = false;
            //    bool isInputOK = true;

            //    string input = Console.ReadLine();

            //    if (input.Length <= 100 && input.Length >= 2)
            //    {
            //        isLengthOK = true;
            //    }

            //    string id = input.ToLower();

            //    bool isEngOK;
            //    bool isIntOK;
            //    bool hasEng = false;
            //    bool hasInt = false;

            //    for (int i = 0; i < id.Length; ++i)
            //    {
            //        isEngOK = id[i] >= 'a' && id[i] <= 'z';
            //        isIntOK = id[i] >= '0' && id[i] <= '9';

            //        if (isEngOK)
            //        {
            //            hasEng = true;   
            //        }
            //        else if(isIntOK)
            //        {
            //            hasInt = true;
            //        }

            //        if(hasInt && hasEng) { isInputOK = true; }
            //        else { isInputOK = false; }

            //    }


            //    if (!isLengthOK || !isInputOK) { Console.WriteLine("다시 입력하세요"); }
            //    else { isOK = true; }
            //}

            #endregion
            #region 9번
            //int[] score = new int[5];

            //for (int i = 0; i < score.Length; ++i)
            //{
            //    score[i] = int.Parse(Console.ReadLine());
            //}

            //int max = int.MinValue;
            //int min = int.MaxValue;
            //int maxindex = 0;
            //int minindex = 0;
            //for (int i = 0; i < score.Length; ++i)
            //{
            //    if (score[i] < min) { min = score[i]; maxindex = i; }
            //    if (score[i] > max) { max = score[i]; minindex = i; }
            //}

            //float sum = 0.0f;
            //for (int i = 0; i < score.Length; ++i)
            //{
            //    if (i == maxindex || i == minindex)
            //        continue;
            //    sum += score[i];
            //}
            //float result = sum / 3.0f;
            //Console.WriteLine(result.ToString("0.00"));

            #endregion
            #region 10번
            // 0  0  0. 0 0 0. 0 0 0. 0 0 0
            // 11 10 9  8 7 6  5 4 3  2 1 0

            //string ipInput = Console.ReadLine();

            //string[] ipSplit = ipInput.Split('.');
            //byte[] ipaddr = new byte[4];

            //for (int i = 0; i < ipSplit.Length; ++i)
            //{
            //    ipaddr[i] = byte.Parse(ipSplit[i]);
            //}

            //uint ip = 0;
            //ip |= (uint)ipaddr[0] << 24;
            //ip |= (uint)ipaddr[1] << 16;
            //ip |= (uint)ipaddr[2] << 8;
            //ip |= ipaddr[3];
            //Console.WriteLine(ip.ToString("X"));


            #endregion
            #endregion

            #region 6교시
            //Car car = new Car();
            //car.carNumber = 10;
            //Console.WriteLine(car.carNumber);

            //Random rnd = new Random();

            //Console.WriteLine(rnd.Next(0, 100));
            //Console.WriteLine(rnd.NextDouble() * 100);
            //Console.WriteLine(rnd.NextDouble() * 100);
            //Console.WriteLine(rnd.NextDouble() * 100);

            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(13);
            //list.Add(12);
            //list.Add(9);
            //list.Sort();

            //Console.WriteLine(Math.Abs(-15415));
            //Console.WriteLine(Math.Ceiling(154.15));
            //Console.WriteLine(Math.Floor(154.15));
            //Console.WriteLine(Math.Max(154, 15));
            //Console.WriteLine(Math.Min(154, 15));
            //Console.WriteLine(Math.Round(154.15));
            #endregion
        }
    }
}
