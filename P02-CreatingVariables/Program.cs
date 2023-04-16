using System;

namespace P02_CreatingVariables;

internal static class Program
{
  static void Main(string[] args)
  {
    // variables
    Console.WriteLine("Variables:");
    char character = 'a';
    string name = "Tiago Barbosa";
    short smallNumber = 10000;
    int age = 37;
    long bigNumber = 1000000000000000000;
    double salary = 7000.50;
    float bonus = 3219.40f;
    Boolean active = true;

    Console.WriteLine("character - " + character); 
    Console.WriteLine("string - " + name); 
    Console.WriteLine("short - " + smallNumber); 
    Console.WriteLine("int - " + age); 
    Console.WriteLine("long - " + bigNumber); 
    Console.WriteLine("double - " + salary); 
    Console.WriteLine("float - " + bonus);  
    Console.WriteLine("Boolean - " + active);
    
    // casting
    Console.WriteLine("\nCasting:");
    int exampleCasting = (int)salary;
    Console.WriteLine("exampleCasting - " + exampleCasting);
  }
}