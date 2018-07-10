using System;
using System.Globalization;

namespace Uptime
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("UpTime.exe is a Freeware written by Freddy Juhel in 2013\n");
      var ts = TimeSpan.FromMilliseconds(Environment.TickCount);
      int nombreDeTicks = Environment.TickCount; // &Int32.MaxValue;
      Console.WriteLine("System is up since {0:HH:mm:ss} milliseconds\n", Environment.TickCount.ToString(CultureInfo.CurrentCulture));
      Console.WriteLine("which is {0} day{1} {2} hour{3} {4} minute{5} {6} second{7} {8} millisecond{9}\n",
        ts.Days, Plural(ts.Days), ts.Hours, Plural(ts.Hours), ts.Minutes, Plural(ts.Minutes), ts.Seconds, Plural(ts.Seconds), ts.Milliseconds, Plural(ts.Milliseconds));
      display("Press a key to exit:");
      Console.ReadKey();
    }

    private static string Plural(Int32 number)
    {
      return number > 1 ? "s" : string.Empty;
    }
  }
}
