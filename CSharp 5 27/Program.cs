using System;
using System.Collections.Generic;
namespace CSharp_5_27
{
    class Program
    {
        #region 4교시


        //class Parent
        //{
        //    public int variable = 2525;
        //    public virtual void Method() { Console.WriteLine("부모 메소드"); }
        //}

        //class Child : Parent
        //{
        //    public new string variable = "하이하이";

        //    public override void Method() { Console.WriteLine("자식 메소드"); }
        //    //public void Method() { Console.WriteLine("자식"); }
        //    // 하이딩
        //    // 부보의 메소드와 멤버변수를 가린다.
        //    // new 붙여주면 명시적으로 해줌
        //}

        //public static int number = 10;

        class Animal
        {
            public virtual void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        }
        class Dog : Animal
        {
            public override void Eat() { Console.WriteLine("강아지 사료를 먹습니다."); }
        }
        class Cat : Animal
        {
            public override void Eat() { Console.WriteLine("고양이 사료를 먹습니다"); }
        }

        #endregion
        
        
        static void Main(string[] args)
        {
            #region 4교시

            //int number = 20;
            //Console.WriteLine(number);

            //Child child = new Child();

            //Console.WriteLine(child.variable);
            //child.Method();
            // 자식 변수 접근함

            //Console.WriteLine(((Parent)child).variable);
            //((Parent)child).Method(); // <= override 하면 어찌됬던간에 최종적으로 override 한 곳으로 감
            // 부모 변수 접근함

            //Parent parent = new Parent();
            //parent.Method();

            //Console.WriteLine((child as Parent).variable);
            //(child as Parent).Method();
            // as 로 접근

            List<Animal> list = new List<Animal>()
            {
                new Animal(), new Dog(), new Cat()
            };

            foreach(var item in list)
            {
                item.Eat();
            }
            // 하이딩을 하면 var == Animal
            // override 하면 override 한 거로 실행이 됨
            
            #endregion
        }
    }
}
