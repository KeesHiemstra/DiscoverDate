using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekNumber_1903402;

namespace WeekNumber_1903601
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Today: {DateTime.Now.ToString("yyyy-MM-dd")}");
      string Reference = "1903401";

      Console.Write($"Reference {Reference} => ");
      DateTime? date = CalculateDate(Reference);
      if (date == null)
      {
        Console.WriteLine("Is invalid");
      }
      else
      {
        Console.WriteLine(date);
      }

      Console.Write("\nPress any key...");
      Console.ReadKey();
    }

    private static DateTime? CalculateDate(string reference)
    {
      int Year = -1;
      int.TryParse(reference.Substring(0, 2), out Year);
      if (Year == -1)
      {
        return null;
      }

      Year = Year + 2000;

      int Week = -1;
      int.TryParse(reference.Substring(2, 2), out Week);
      if (Week == -1)
      {
        return null;
      }

      int Day = -1;
      int.TryParse(reference.Substring(4, 1), out Day);
      if (Day == -1)
      {
        return null;
      }

      DateTime ThisYear = new DateTime(Year, 1, 1);
      DateTimeWeekNumber dwn = new DateTimeWeekNumber(ThisYear);

      //Begin of the week
      ThisYear = ThisYear.AddDays(1 - dwn.DayNo);

      int Days = (Week - 1) * 7 + (Day - 1);

      return ThisYear.AddDays(Days);
    }
  }
}
