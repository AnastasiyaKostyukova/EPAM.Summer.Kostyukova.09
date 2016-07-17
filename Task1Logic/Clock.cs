using System;
using System.Threading;

namespace Task1Logic
{
  /// <summary>
  /// class Clock with 2 events EndTimeEventHandler and TickEventHandler
  /// </summary>
  public class Clock
  {
    private int _timeCount;
    private int _fullTime;
    private Timer _timer;


    public event EventHandler<ClockEventArgs> EndTimeEventHandler;
    public event EventHandler<ClockEventArgs> TickEventHandler;

    public void StartClock(int time)
    {
      _fullTime = time;
      _timeCount = time;
      _timer = new Timer(TickMethod, null, 0, 1000);
    }

    /// <summary>
    /// private method TickMethod.
    /// </summary>
    private void TickMethod(object ob)
    {
      _timeCount--;
      TickEventHandler(null, new ClockEventArgs("Tick", _timeCount));
      if (_timeCount == 0)
      {
        _timer.Dispose();
        if (EndTimeEventHandler != null)
        {
          var eventArgs = new ClockEventArgs("DON'T SLEEP! TIME IS END! DIN-DON", _fullTime);
          EndTimeEventHandler(null, eventArgs);
        }
      }
    }
  }
}
