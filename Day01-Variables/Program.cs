class Program
{
    static void Main()
    {
        var myName = "Uzair";
        var price=19.99;
        const double Pi = 3.14159;
        const int maxStudents = 50;
        var radius = 5;
        double area = Pi * radius * radius;

        Console.WriteLine($"My Name is {myName}");
        Console.WriteLine($"The Price is {price}");
        Console.WriteLine($"Pi Value is {Pi}");
        Console.WriteLine($"Max Students Are {maxStudents}");
        Console.WriteLine($"Radius is {radius}");
        Console.WriteLine($"Area Is {area}");

        Console.WriteLine("");
        Console.WriteLine($"myName type: {myName.GetType()}");
        Console.WriteLine($"price type: {price.GetType()}");
        Console.WriteLine($"radius type: {radius.GetType()}");
    }
}