class Program
{
    static void Main()
    {
       int x = 10;
       x += 5;   // x = x + 5  → x becomes 15
       Console.WriteLine($"Plus {x}");
       x -= 3;   // x = x - 3  → x becomes 12
       Console.WriteLine($"Minus {x}");
       x *= 2;   // x = x * 2  → x becomes 24
       Console.WriteLine($"Multiply {x}");
       x /= 4;   // x = x / 4  → x becomes 6
       Console.WriteLine($"Qoutient {x}");
       x %= 5;   // x = x % 5  → x becomes 1
       Console.WriteLine($"Modulus {x}");
        Console.WriteLine("");

       int counter=10;
       Console.WriteLine($"Initial: {counter}");
       counter+=5;
       Console.WriteLine($"Add by 5:- {counter}");
       counter*=2;
       Console.WriteLine($"Multiply by 2:- {counter}");
       counter-=3;
       Console.WriteLine($"Subtract by 3:- {counter}");
    }
}