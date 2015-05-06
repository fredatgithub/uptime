/*
The MIT License(MIT)
Copyright(c) 2015 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Globalization;
using System.Text;

namespace Uptime
{
  class Program
  {
    static void Main()
    {
      Action<string> display = s => Console.WriteLine(s);
      display("UpTime.exe is a Freeware written by Freddy Juhel in 2013\n");
      var ts = TimeSpan.FromMilliseconds(Environment.TickCount);
      int nombreDeTicks = Environment.TickCount; // &Int32.MaxValue;
      Console.WriteLine("System is up since {0:HH:mm:ss} milliseconds\n", Environment.TickCount.ToString(CultureInfo.CurrentCulture));
      Console.WriteLine("which is {0} day{1} {2} hour{3} {4} minute{5} {6} second{7} {8} millisecond{9}\n",
        ts.Days, Plural(ts.Days), ts.Hours, Plural(ts.Hours), ts.Minutes, Plural(ts.Minutes), ts.Seconds, Plural(ts.Seconds), ts.Milliseconds, Plural(ts.Milliseconds));
      display("Press a key to exit:");
      Console.ReadKey();
    }

    private static string Plural(double number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(byte number)
    {
      return number > 1 ? "s" : string.Empty;
    }
    private static string Plural(sbyte number)
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

    private static string BuildUpTime(int time)
    {
      StringBuilder result = new StringBuilder();
      if (HasHours(time))
      {
        result.Append(time / 216000000);
      }
      else
      {
        result.Append("00 hour ");
      }

      if (HasMinutes(time))
      {
        result.Append(time / 216000000);
      }
      else
      {
        result.Append("00 minute ");
      }

      if (HasSeconds(time))
      {
        result.Append(time / 216000000);
      }
      else
      {
        result.Append("00 second ");
      }

      if (HasMilliSeconds(time))
      {
        result.Append(time / 216000000);
      }
      else
      {
        result.Append("00 millisecond ");
      }

      return result.ToString();
    }

    private static bool HasHours(int time)
    {
      return ((time / 216000000) > 0);
    }

    private static bool HasMinutes(int time)
    {
      return ((time / 3600000) > 0);
    }

    private static bool HasSeconds(int time)
    {
      return ((time / 60000) > 0);
    }

    private static bool HasMilliSeconds(int time)
    {
      return time > 0;
    }
  }
}