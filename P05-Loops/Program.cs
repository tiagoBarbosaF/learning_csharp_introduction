namespace P05_Loops;

internal static class Program
{
  private static void Main(string[] args)
  {
    double investiment = 1000.0;
    int month = 1;

    Console.WriteLine("Using While: ");
    while (month <= 12)
    {
      investiment *= 1.005;
      Console.WriteLine("Month: " + month + " - Rentability: $ " + investiment.ToString("F"));
      month++;
    }

    double investiment2 = 2000.0;
    Console.WriteLine("\nUsing For:");
    for (int i = 1; i <= 12; i++)
    {
      investiment2 *= 1.005;
      Console.WriteLine("Month: " + i + " - Rentability: $ " + investiment2.ToString("F"));
    }

    Console.WriteLine("\nChained loops:");
    double rentabilityFactor = 1.005;
    double investiment3 = 1000.0;

    for (int i = 1; i <= 5; i++)
    {
      for (int j = 1; j <= 12; j++)
      {
        investiment3 *= rentabilityFactor;
      }

      Console.WriteLine("Year: " + i + " - Rentability: $ " + investiment3.ToString("F"));
      rentabilityFactor += 0.001;
    }

    Console.WriteLine("\nChained loops 2:");
    for (int i = 0; i < 6; i++)
    {
      for (int j = 0; j < 6; j++)
      {
        Console.Write("*");
        if (j >= i)
        {
          break;
        }
      }

      Console.WriteLine();
    }
    
    for (int i = 0; i < 6; i++)
    {
      for (int j = 0; j < 6; j++)
      {
        Console.Write(j + 1);
        if (j >= i)
        {
          break;
        }
      }

      Console.WriteLine();
    }
  }
}