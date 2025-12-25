using System;

class Program
{
    static void Main()
    {
        //Variables for a Person
        string name="Uzair";
        int myAge=33;
        decimal salary=50000.75m;
        bool isEmployed=true;

        Console.WriteLine($"My Name is: {name}");
        Console.WriteLine($"My Age is: {myAge}");
        Console.WriteLine($"My Salary is: {salary}");
        Console.WriteLine($"Am I Employed?: {isEmployed}");
    }
}