using System;

// README.md를 읽고 코드를 작성하세요.

class CodPrac
{
    static void Main()
    {
        //Prac_1_1();
        //Prac_1_2();
        //Prac_2();
        //Prac_3_1();
        Prac_3_2();
    }

    static void Prac_1_1()
    {
        Parent parent = new Parent();
        parent.Work();
        Child child = new Child();
        child.Work();
    }

    static void Prac_1_2()
    {
        Animal animal = new Animal();
        animal.Eat();
        Animal cat = new Cat();
        cat.Eat();
    }

    static void Prac_2()
    {
        Child1 child1 = new Child1();
        child1.Say();
        child1.Run();
        child1.Walk();
        Parent1 parent1 = child1;
        parent1.Say();
        parent1.Run();
        parent1.Walk();
    }

    static void Prac_3_1()
    {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1.5, 2.5));
        Console.WriteLine(calculator.Add(1, 2, 3));

    }

    static void Prac_3_2()
    {
        Animal1 animal1 = new Animal1();
        animal1.Speak();
        Animal1 dog1 = new Dog1();
        dog1.Speak();
        Animal1 cat1 = new Cat1();
        cat1.Speak();
    }


}
