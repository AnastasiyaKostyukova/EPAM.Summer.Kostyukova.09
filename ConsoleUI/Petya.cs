using System;
using Task1Logic;

namespace ConsoleUI
{
  class Petya
  {
    public void BudilnikPeti(object s, ClockEventArgs e)
    {
      Console.WriteLine("Petr method: {0}", e.Message);
    }
  }
}
