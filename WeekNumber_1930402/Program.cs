using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekNumber_1903402
{
  class Program
  {

    public static void Main(string[] args)
    {
      DateTimeWeekNumber dtwn = new DateTimeWeekNumber(DateTime.Parse("2006-12-31"));

      Console.WriteLine("ISO standards sample (2006-12-31):");
      Console.WriteLine($"ISOWeekNoExtended: {dtwn.ISOWeekNoExtended}");
      Console.WriteLine($"ISOWeekNoCompact : {dtwn.ISOWeekNoCompact}");
      Console.WriteLine($"WeekNoExtended   : {dtwn.WeekNoExtended}");
      Console.WriteLine($"WeekNoCompact    : {dtwn.WeekNoCompact}");

      Console.WriteLine();
      dtwn = new DateTimeWeekNumber(DateTime.Now);
      Console.WriteLine($"Today ({DateTime.Now.ToString("yyyy-MM-dd")}):");
      Console.WriteLine($"DayNo            : {dtwn.DayNo} ({DateTime.Now.DayOfWeek})");
      Console.WriteLine($"WeekNo           : {dtwn.WeekNo}");
      Console.WriteLine($"WeekNoString2    : {dtwn.WeekNoString2}");
      Console.WriteLine($"YearNo           : {dtwn.YearNo}");
      Console.WriteLine($"Today (ToString) : {dtwn.ToString()}");

      Console.WriteLine();
      Console.WriteLine($"WeekNoCompact    : {dtwn.WeekNoCompact}");

      Console.Write("\nPress any key...");
      Console.ReadKey();
    }
  }
}
