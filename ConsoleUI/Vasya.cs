using System;
using Task1Logic;

namespace ConsoleUI
{
  class Vasya
  {
    public void BudilnikVasi(object s, ClockEventArgs e)
    {
      Console.WriteLine("A eto Vasin budilnik: {0}", e.Message);
    }
  }
}
