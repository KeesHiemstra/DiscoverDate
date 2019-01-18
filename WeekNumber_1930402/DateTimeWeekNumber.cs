﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekNumber_1930402
{
  public class DateTimeWeekNumber
  {
    /// <summary>
    /// Day number of the week (1 = Monday, 7 = Sunday).
    /// </summary>
    public int DayNo { get; private set; }

    /// <summary>
    /// Week number of the year.
    /// </summary>
    public int WeekNo { get; private set; }

    /// <summary>
    /// Year can be corrected.
    /// </summary>
    public int YearNo { get; private set; }

    public string WeekNoString
    {
      get
      {
        return WeekNo.ToString();
      }
    }

    public string WeekNoString2
    {
      get
      {
        return $"0{WeekNoString}".Substring(WeekNoString.Length - 1);
      }
    }

    private static DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
    private static Calendar cal = dfi.Calendar;

    public DateTimeWeekNumber(DateTime date)
    {
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

      DayNo = (int)date.DayOfWeek;
      if (DayNo == 0)
      {
        DayNo = 7;
      }
      WeekNo = week;
      YearNo = year;
    }

    public override string ToString()
    {
      return $"{YearNo.ToString().Substring(2, 2)}{WeekNoString2}{DayNo.ToString()}";
    }
  }
}
