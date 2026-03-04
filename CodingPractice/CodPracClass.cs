using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

class Parent
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}

class Child : Parent
{
    public override void Work()
    {
        Console.WriteLine("프로게이머");
    }
}

class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal Eat");
    }
}
class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat Eat");
    }
}

class Parent1
{
    public void Say() => Console.WriteLine("부모_안녕하세요");
    public void Run() => Console.WriteLine("부모_달리다.");
    public virtual void Walk() => Console.WriteLine("부모_걷다");
}
class Child1 : Parent1
{
    public new void Say() => Console.WriteLine("자식_안녕하세요");
    public new void Run() => Console.WriteLine("자식_달리다.");
    public override void Walk() => Console.WriteLine("자식_걷다");
}

class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
}

class Animal1
{
    public virtual void Speak() => Console.WriteLine("동물이 소리를 낸다");
}

class Dog1 : Animal1
{
    public override void Speak() => Console.WriteLine("멍멍!");
}

class Cat1 : Animal1
{
    public override void Speak() => Console.WriteLine("야옹!");
}