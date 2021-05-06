using System;
using System.Collections.Generic;

namespace CSharp_5_6
{
    class Program
    {

        #region 4교시

        //class Test
        //{
        //    int value = 0;                 // 필드
        //    public int Add(int a, int b)   // 메서드
        //    {
        //        return a + b;
        //    }
        //}

        //class Item
        //{
        //    public ulong id;
        //}

        //class User
        //{
        //    private List<Item> list = new List<Item>();

        //    public void AddItem(Item item)
        //    {
        //        list.Add(item);
        //    }

        //    public Item GetBiggestID()
        //    {
        //        ulong maxID = ulong.MinValue;
        //        int itemIndex = 0;

        //        for(int i = 0; i < list.Count; ++i)
        //        {
        //            if(maxID <= list[i].id)
        //            {
        //                maxID = list[i].id;
        //                itemIndex = i;
        //            }
        //        }

        //        return list[itemIndex];
        //    }

        //    public ulong GetItemID(Item item)
        //    {
        //        return item.id;
        //    }
        //}

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        #endregion

        #region 5교시

        //public static int Abs(int input)
        //{
        //    return input < 0 ? -input : input;
        //}
        //public static double Abs(double input)
        //{
        //    return input < 0 ? -input : input;
        //}
        //public static long Abs(long input)
        //{
        //    return input < 0 ? -input : input;
        //}



        //class Fruit
        //{
        //            public  string   name;
        //            public  int      price;
        //    static  public  int      count = 0;

        //    public Fruit()
        //    {
        //        ++count;
        //    }

        //    public Fruit(string name, int price)
        //    {
        //        this.name = name;
        //        this.price = price;

        //        ++count;
        //    }
        //};

        //class Hidden
        //{
        //    static public Hidden Create() { return new Hidden(); }
        //    private Hidden() { }
        //}

        //class Sample
        //{
        //    public static int value;
        //    static Sample()
        //    {
        //        value = 10;
        //        Console.WriteLine("정적 생성자 호출");
        //    }
        //}

        #endregion

        #region 6교시

        //class Product
        //{
        //    public string name = null;

        //    public const int BDATE = 225;
        //    public readonly int YEAR = 0;

        //    public Product(string name)
        //    {
        //        YEAR = 2004;

        //        this.name = name;
        //        Console.WriteLine($"{this.name} 의 생성자 호출");
        //    }

        //    ~Product()
        //    {
        //        Console.WriteLine($"{this.name} 의 소멸자 호출");
        //    }
        //}

        //static void Method1()
        //{
        //    Product p2 = new Product("고구마호박");
        //}

        //class Box
        //{
        //    private int width;
        //    private int height;

        //    public int Width { get { return width; } set { if (value < 5) width = value; } }
        //    public int Height { get; set; }

        //    public int getSomething { get { Console.WriteLine("어림도없지"); return 0; } set { Console.WriteLine("이것도 어림도없지"); } }


        //    //public int GetWidth() { return width; }
        //    //public void SetWidth(int width)
        //    //{
        //    //    if(width > 0)
        //    //    {
        //    //        this.width = width;
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("오이런");
        //    //    }
        //    //}
        //}

        class Player
        {
            private uint level;

            public uint Level { get { return level; } set { if (value <= 100 && value > 0) level = value; else { Console.WriteLine("?"); } } }
        }


        #endregion

        static void Main(string[] args)
        {

            #region 4교시
            // 까먹고 앞에껄 지웠

            //Test test = new Test();
            //Console.WriteLine(test.Add(10, 20));
            //User user = new User();

            //user.AddItem(new Item() { id = 10077 });
            //user.AddItem(new Item() { id = 10112 });
            //user.AddItem(new Item() { id = 16245 });
            //user.AddItem(new Item() { id = 11252 });
            //user.AddItem(new Item() { id = 12442 });
            //user.AddItem(new Item() { id = 12212 });

            //Console.WriteLine(user.GetBiggestID().id);


            //Console.WriteLine(new Program().Add(10, 20));
            //Console.WriteLine(Add(10, 20)); // static Add();
            #endregion

            #region 5교시

            //Console.WriteLine(Abs(300L));
            //Fruit f = new Fruit();
            //Console.WriteLine(f.name);
            //Console.WriteLine(f.price);

            //Fruit fruit  = new Fruit("감자", 1000); Console.WriteLine(Fruit.count);
            //Fruit fruit1 = new Fruit("감자", 1000); Console.WriteLine(Fruit.count);
            //Fruit fruit2 = new Fruit("감자", 1000); Console.WriteLine(Fruit.count);
            //Fruit fruit3 = new Fruit("감자", 1000); Console.WriteLine(Fruit.count);
            //Fruit fruit4 = new Fruit("감자", 1000); Console.WriteLine(Fruit.count);

            //Console.WriteLine($"{fruit.name} {fruit.price}");

            //Hidden hidden = Hidden.Create();

            //Console.WriteLine("첫 번째");
            //Console.WriteLine(Sample.value);
            //Console.WriteLine("두 번째");
            //Sample sample = new Sample();
            //Console.WriteLine("세 번째");

            #endregion

            #region 6교시

            //Product p1 = new Product("우앱");
            //Product p2 = new Product("asdf");
            //Method1();

            //Box b1 = new Box();
            //b1.Width = 5;

            //Console.WriteLine(b1.Width);

            //int a = b1.getSomething;
            //b1.getSomething = 10;
            //Console.WriteLine(b1.getSomething);

            Player player = new Player();
            player.Level = 10000;
            player.Level = 100;
            Console.WriteLine(player.Level);


            #endregion
        }



    }
}
