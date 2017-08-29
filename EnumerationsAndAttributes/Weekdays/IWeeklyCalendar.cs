using System;
using System.Collections;
using System.Collections.Generic;
 public  interface IWeeklyCalendar:IEnumerable<IWeeklyEntry>
  {

      void AddEntry(string weekday, string notes);

       IEnumerable<IWeeklyEntry> WeeklySchedule { get; set; }
  }

