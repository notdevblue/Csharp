using System;
using System.Collections.Generic;

namespace Csharp_4_29
{
    #region 4교시
    //class Car
    //{
    //    private int _carNumber = 0;
    //    public int carNumber { get { return _carNumber; } set { _carNumber = carNumber; } }
    //}
    #endregion

    #region 5교시
    //class Product
    //{
    //    public string   name    = "noname";
    //    public int      price   = 0;

    //}

    //class MyMath
    //{
    //    public static double PI = 3.141592;
    //}

    //class Student
    //{
    //    public string name;
    //    public int grade;
    //}

    //class Pet
    //{
    //    public string name;
    //    public int age;
    //}

    //class Person
    //{
    //    public string name;
    //    public string address;
    //    public List<Pet> pet = new List<Pet>();
    //}

    //class LookChickenHouse
    //{
    //    string name;
    //    string phoneNum;
    //    string menu;
    //}

    //class ParkinglotManage
    //{
    //    int maxCarNum;
    //    int curCarNum;
    //}

    //class BookManage
    //{
    //    string name;
    //    string pubdate;
    //    string aurtor;
    //}

    //class SNS
    //{
    //    string name;
    //    string birthdate;
    //    string introduceWorld;
    //    int friendCount;
    //    List<SNS> friendList;
    //}

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            #region 4교시
            // 클래스 키워드 통해 객채지향 만듬
            // car = 인스턴스
            //Car car = new Car();

            //List<int> obj = new List<int>();
            //obj.Add(1);
            //obj.Add(2);
            //obj.Add(3);
            //obj.Add(4);
            //obj.Add(5);

            //foreach(var item in obj)
            //{
            //    Console.WriteLine(item);
            //}

            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car();

            //car1.carNumber = 1;
            //car2.carNumber = 5;
            //car3.carNumber = 4;

            //List<Car> cars = new List<Car>();
            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);

            //foreach(var items in cars)
            //{
            //    Console.WriteLine(items.carNumber);
            //}

            //Myclass ms = new Myclass();
            //// 인스턴스 생성 후 ms.변수 로 접근 <= 인스턴스 변수
            //Myclass2 ms2 = new Myclass2();

            //Car car = new Car();
            //car.carNumber = 154; // <= 인스턴스 변수

            //Math.PI; // <= 클래스 변수

            #endregion
            #region 5-6교시
            ////int[] arr = new int[] { 1, 2, 3 };
            //Product p = new Product() { name = "환쥬", price = 1000 };
            //Product banana = new Product() { name = "바나나", price = 2000 };
            //Console.WriteLine(p.name);
            //Console.WriteLine(p.price);
            //Console.WriteLine(banana.name);
            //Console.WriteLine(banana.price);

            //MyMath math = new MyMath();
            //Console.WriteLine(MyMath.PI);

            //List<Student> list = new List<Student>();
            //list.Add(new Student() { name = "우앱", grade = 1 });
            //list.Add(new Student() { name = "쥬쥬", grade = 2 });
            //list.Add(new Student() { name = "성빈", grade = 2 });
            //list.Add(new Student() { name = "식샌", grade = 4 });
            //list.Add(new Student() { name = "히진", grade = 3 });
            //list.Add(new Student() { name = "대이", grade = 1 });

            //for (int i = list.Count - 1; i >= 0; --i)
            //{
            //    if(list[i].grade > 1)
            //    {
            //        list.RemoveAt(i);
            //    }    
            //}

            //foreach(var item in list)
            //{
            //    //if(item.grade > 1)
            //    {
            //        Console.WriteLine($"이름: {item.name}, 성적: {item.grade}");
            //    }
            //}

            #region 연습문제
            /* 1
             * O
             * X
             * 
             * X
             * X
             * X?
             * O
             * 
             */

            /* 2
             * 왼쪽 인 오른쪽 클?
             */

            /* 3
             * 3
             */

            /* 4
             * 
             */

            //// 5
            //class Unit
            //{
            //    public string name;
            //    public int mineral;
            //    public int supply;
            //    public int hp;
            //    public int atk;
            //}
            //Unit unit = new Unit() { name = "건설로봇", mineral = 50, supply = 1, hp = 45, atk = 5};

            //class Book
            //{
            //    public string name;
            //    public string publishDate;
            //    public string publisher;
            //    public string promoter;
            //    public string promote;
            //    public string promotion;
            //    public string director;
            //    public string editor;
            //    public string design;
            //}
            //Book book = new Book() { name = "PHP 프로그래밍 입문", publishDate = "2013년 5월 20일", publisher = "황재호",
            //    promoter = "김태현", promote = "한빛아카데미(주", promotion = "김현용", director = "김이화", editor = "김이화", design = "여동일" };

            //Person person = new Person() { name = "윤인성", address = "서울특별시 강서구" };
            //person.pet.Add(new Pet() { name = "구름", age = 7 });
            //person.pet.Add(new Pet() { name = "별", age = 1 });

            //Console.WriteLine(person.pet[0].name);
            //Console.WriteLine(person.pet[0].age);
            //Console.WriteLine(person.pet[1].name);
            //Console.WriteLine(person.pet[1].age);


            Random random = new Random();

            int randomNumber = random.Next(0, 1000);

            while(true)
            {
                Console.Write("수를 입력하세요: ");
                int input = int.Parse(Console.ReadLine());
                if (input > randomNumber)
                    Console.WriteLine($"{input} 보다 작습니다");
                else if (input < randomNumber)
                    Console.WriteLine($"{input} 보다 큽니다");
                else
                    break;
            }
            Console.WriteLine("정답입니다!");


            #endregion

            #endregion

        }
    }
}
