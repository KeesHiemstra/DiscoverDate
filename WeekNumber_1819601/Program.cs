using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekNumber_1819601
{
  class Program
  {

    public static void Main(string[] args)
    {

      DateTime startDate = new DateTime(2010, 12, 31);
      for (int i = 0; i < 25; i++)
      {
        Console.WriteLine($"{startDate.ToString("yyyy")} {startDate.WeekNumberString()} " +
          $"{startDate.AddDays(1).WeekNumberString()} {startDate.DayOfWeek}");
        startDate = startDate.AddYears(1);
      }

      Console.WriteLine(DateTime.Parse("2018-08-24").WeekNumberString());

      Console.WriteLine();
      Console.Write("Press any key...");
      Console.ReadKey();
    }
  }

  /// <summary>
  /// Return the WeekNumber from Date
  /// </summary>
  public static class DateTimeExtensions
  {
    public static string WeekNumberString(this DateTime date)
    {
      DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
      Calendar cal = dfi.Calendar;

      int year = date.Year;
      int week = cal.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

      if (week == 52 && date.Month == 1)
      {
        year--;
      }
      else if (week == 53)
      {
        if (date.Month == 12 && date.DayOfWeek <= DayOfWeek.Wednesday)
        {
          week = 1;
          year++;
        }
        else if (date.Month == 1 && date.DayOfWeek >= DayOfWeek.Thursday)
        {
          year--;
        }
      }
      else if (week == 1)
      {

      }

      string weekStr = week.ToString();

      return $"{year}.{("0" + weekStr).Substring(weekStr.Length - 1)}";
    }
  }
}
