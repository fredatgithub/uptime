using System;
using System.Globalization;
using System.Text;

namespace Uptime
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("UpTime.exe is a Freeware written by Freddy Juhel in 2013\n");

      //Console.WriteLine(dt.ToString("dd:HH:mm:ss:ff"));

      //string myDate = new DateTime(Environment.TickCount).ToString("dd:HH:mm:ss:ms");

      var ts = TimeSpan.FromMilliseconds(Environment.TickCount);

      int nombreDeTicks = Environment.TickCount; // &Int32.MaxValue;

      Console.WriteLine("System is up since {0:HH:mm:ss} milliseconds\n", Environment.TickCount.ToString(CultureInfo.CurrentCulture));
      Console.WriteLine("which is {0} day{1} {2} hour{3} {4} minute{5} {6} second{7} {8} millisecond{9}\n",
        ts.Days, Plural(ts.Days), ts.Hours, Plural(ts.Hours), ts.Minutes, Plural(ts.Minutes), ts.Seconds, Plural(ts.Seconds), ts.Milliseconds, Plural(ts.Milliseconds));
      Console.WriteLine("Press a key to exit:");
      Console.ReadKey();
    }

    private static string Plural(double number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(Byte number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(SByte number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(Int16 number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(Int32 number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(Int64 number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(UInt16 number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(UInt32 number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(UInt64 number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(float number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(decimal number)
    {
      return number > 1 ? "s" : string.Empty;
    }

    private static string BuildUpTime(int temps)
    {
      StringBuilder result = new StringBuilder();
      if (HasHours(temps))
      {
        result.Append(temps / 216000000);
      }
      else
      {
        result.Append("00 hour ");
      }

      if (HasMinutes(temps))
      {
        result.Append(temps / 216000000);
      }
      else
      {
        result.Append("00 minute ");
      }

      if (HasSeconds(temps))
      {
        result.Append(temps / 216000000);
      }
      else
      {
        result.Append("00 second ");
      }

      if (HasMilliSeconds(temps))
      {
        result.Append(temps / 216000000);
      }
      else
      {
        result.Append("00 millisecond ");
      }

      return result.ToString();
    }

    private static bool HasHours(int temps)
    {
      return ((temps / 216000000) > 0);
    }

    private static bool HasMinutes(int temps)
    {
      return ((temps / 3600000) > 0);
    }

    private static bool HasSeconds(int temps)
    {
      return ((temps / 60000) > 0);
    }

    private static bool HasMilliSeconds(int temps)
    {
      return temps > 0;
    }
  }
}