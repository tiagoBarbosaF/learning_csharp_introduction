namespace P04_Challenge01;

internal static class Program
{
  private static void Main(string[] args)
  {
    double salary = 3300.0;

    if (salary is >= 1900.0 and <= 2800.0)
    {
      Console.WriteLine("Taxes for deduce is 7.5%. Value to deduce: $ 142.00");
    } else if (salary is > 2800.0 and <= 3751.0)
    {
      Console.WriteLine("Taxes for deduce is 15%. Value to deduce: $ 350.00");
    } else if (salary is > 3751.0 and <= 4664.0)
    {
      Console.WriteLine("Taxes for deduce is 22.5%. Value to deduce: $ 636.00");
    }
  }
}