using ConsoleUI;
using System;
using Task1Logic;

namespace Task1ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      Clock test = new Clock();
      test.EndTimeEventHandler += ShowMessage;
      test.StartClock(15);
      test.TickEventHandler += TickShowMessage;

      var vasya = new Vasya();
      var petr = new Petya();

      test.EndTimeEventHandler += petr.BudilnikPeti;
      test.EndTimeEventHandler += vasya.BudilnikVasi;

      test.EndTimeEventHandler -= petr.BudilnikPeti;
      Console.ReadLine();
    }

    static void ShowMessage(object s, ClockEventArgs e)
    {
      Console.WriteLine("Message: {0}; FullTime: {1}\a", e.Message, e.Time);
    }

    static void TickShowMessage(object s, ClockEventArgs e)
    {
      Console.Clear();
      Console.WriteLine("tick message: {0}; Time: {1}", e.Message, e.Time);

      if (e.Time < 5)
      {
        Console.Beep();
      }
    }
  }
}
