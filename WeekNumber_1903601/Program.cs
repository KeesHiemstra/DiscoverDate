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
      DateTime? date = DateTimeWeekNumber.WeekNoCompactToDate(Reference);
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
  }
}
