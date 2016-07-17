using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
  /// <summary>
  /// class ClockEventArgs. Can to transmit a message and additional information (full time)
  /// about the event to anyone type.
  /// </summary>
  public class ClockEventArgs : EventArgs
  {
    public ClockEventArgs (string msg, int fullTime)
    {
      Message = msg;
      Time = fullTime;
    }

    public int Time { get; private set; }
    public string Message { get; private set; }
  }
}
