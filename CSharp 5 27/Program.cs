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

        //class Animal
        //{
        //    public virtual void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        //}
        //class Dog : Animal
        //{
        //    public override void Eat() { Console.WriteLine("강아지 사료를 먹습니다."); }
        //}
        //class Dog : Animal
        //{
        //    public new void Eat() { Console.WriteLine("강아지 사료를 먹습니다."); } // 이러면 부모것이 실행이 됨
        //}
        //class Cat : Animal
        //{
        //    public override void Eat() { Console.WriteLine("고양이 사료를 먹습니다"); }
        //}
        //class Bird : Animal
        //{
        //    public override void Eat() { Console.WriteLine("새 사료를 먹습니다"); }
        //}
        //class Bird2 : Bird
        //{
        //    public override void Eat() { Console.WriteLine("Bird2 사료를 먹습니다"); }
        //}

        //sealed class Parent // <= 상속을 못하게 막음
        //{

        //}

        //abstract class GrandParent // <= 상속을 강제함 == new GrandParent() 가 불가능 (이거로 인스턴스 못함)
        //{
        //    public virtual void Foo() { Console.WriteLine("와센즈"); }
        //}

        //class Parent : GrandParent
        //{
        //    public override void Foo() { Console.WriteLine("와센즈"); }
        //}

        //class Child : Parent
        //{
        //    public sealed override void Foo() { Console.WriteLine("와센즈"); }
        //}

        //class GrandChild : Child
        //{
        //    //public override void Foo() { Console.WriteLine("와센즈"); } // <= 불가능
        //}


        #endregion
        #region 5교시

        //abstract class Parent
        //{
        //    //public virtual void Foo() { Console.WriteLine("부모"); }
        //    public abstract void Foo();
        //}

        //class Child : Parent
        //{
        //    //public override void Foo() { Console.WriteLine("자식"); }
        //    public override void Foo() { Console.WriteLine("자식22"); }
        //}

        //class GrandChild : Child
        //{
        //    public override void Foo() { Console.WriteLine("자식2"); }
        //}

        //interface IParent
        //{
        //    void Method();
        //}

        //class Child : IParent
        //{
        //    public override void Method()
        //    {

        //    }
        //}

        //class Player
        //{
        //    public string name;
        //    public int hp;
        //    public virtual void Attack() { }
        //}

        //class Hero : Player
        //{
        //    public void Walk() { }
        //    public override void Attack()
        //    {
        //        Console.WriteLine("Hero");
        //    }
        //}

        //class Monster : Player
        //{
        //    public void Move() { }
        //    public void Skill() { }
        //    public override void Attack()
        //    {
        //        Console.WriteLine("Monster");
        //    }
        //}

        //class Boss : Player
        //{
        //    public void SpecialSkill() { }
        //    public override void Attack()
        //    {
        //        Console.WriteLine("Boss");
        //    }
        //}

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

            //List<Animal> list = new List<Animal>()
            //{
            //    new Animal(), new Dog()/*, new Cat(), new Bird(), new Bird2()*/
            //};

            //foreach(var item in list)
            //{
            //    item.Eat();
            //}
            // var == Animal
            // override 하면 override 한 거로 실행이 됨

            #endregion
            #region 5교시

            //Parent a = new GrandChild();
            //a.Foo();

            //Parent a = new Parent(); // <= 에러
            //Parent b = new GrandChild();

            //Parent a = new Child();
            //a.Foo();

            //List<Player> playerList = new List<Player>() { new Hero(), new Monster(), new Boss() };
            //foreach(var item in playerList)
            //{
            //    item.Attack();
            //}

            #endregion

            #region 연습문제

            /* 1번
             * 1 상속
             * 2 :
             * 3 public, protected
             * 4 private
             * 5 
             * 6 쉐도잉?
             * 7 sealed
             * 8 sealed
             * 9 abstract
             */

            /* 2번
             * 1 X
             * 2 O
             * 3 O
             * 4 O
             * 5
             * 6 O
             * 7 O
             */

            /* 3번
             * 1
             */

            /* 4번
             * 2 1 3
             */

            /* 5번
             * 2
             */

            /* 6번
             * 20
             */

            /* 7번
             * (child as Parent).question 또는 ((Parent)child).question
             */

            /* 8번
             * 20
             */

            /* 9번
             * 20
             */

            /* 10번
             * 20
             */

            /* 11번
             * 20
             */


            #endregion
        }
    }
}
