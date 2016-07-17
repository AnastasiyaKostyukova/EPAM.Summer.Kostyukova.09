using System;
using System.Linq;
using Task3Logic;

namespace Task3ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      var test = new WordCounter();
      var firstTest = test.Counter(@"D:\Training EPAM Nastya\Tasks\Day9\book2.txt");

      foreach (var pair in firstTest.OrderByDescending(r => r.Value).Take(1000))
      {
        Console.WriteLine("{0}______{1}", pair.Key, pair.Value);
      }
      Console.WriteLine(firstTest.Count());
    }
  }
}
