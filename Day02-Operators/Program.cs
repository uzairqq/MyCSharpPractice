class Program
{
    static void Main()
    {
       int num1 =10;
       int num2=4;

       //Addition
       int sum=num1+num2;
       Console.WriteLine($"Sum: {sum}");

       //Subtraction
       int difference=num1-num2;
       Console.WriteLine($"Difference {difference}");

       //Multiplication
       int product=num1*num2;
       Console.WriteLine($"Product {product}");

       //Division
       int quotient=num1/num2;
       Console.WriteLine($"Quotient {quotient}");

       // Decimal division
       double quotientDecimal = (double)num1 / num2;
       Console.WriteLine($"Decimal Quotient: {quotientDecimal}");

       //Modulus (remainder)
       int remainder=num1%num2;
       Console.WriteLine($"Remainder {remainder}");


    }
}