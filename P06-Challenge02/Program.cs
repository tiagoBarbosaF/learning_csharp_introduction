namespace P06_Challenge02;

internal static class Program
{
  private static void Main(string[] args)
  {
    for (int i = 1; i < 101; i++)
    {
      if (i % 3 == 0)
      {
        Console.WriteLine("Number " + i + " multiple of 3");
      }
    }
  }
}