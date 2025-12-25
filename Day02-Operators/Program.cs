class Program
{
    static void Main()
    {
      int counter=0;

      counter++; //counter=1
      Console.WriteLine($"Incremented First Time: {counter}");

      counter++; //counter=2
      Console.WriteLine($"Incremented Second Time: {counter}");

      counter++; //counter=3
      Console.WriteLine($"Incremented Third Time: {counter}");

      counter--; //counter=2
      Console.WriteLine($"Decremented Once: {counter}");
    }
}