namespace P03_Conditionals;

internal static class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Conditionals:");

    int age = 16;
    int quantityResponsible = 1;

    var accompanied = quantityResponsible > 0;
    if (age >= 18 || accompanied)
    {
      Console.WriteLine("You can enter!");
    }
    else
    {
      Console.WriteLine("You cannot enter!");
    }
  }
}