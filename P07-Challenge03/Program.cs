namespace P07_Challenge03;

internal static class Program
{
  private static void Main(string[] args)
  {
    int factorial = 1;

    for (int i = 1; i < 11; i++)
    {
      factorial *= i;
      Console.WriteLine("Factorial of " + i + " = " + factorial);
    }
  }
}