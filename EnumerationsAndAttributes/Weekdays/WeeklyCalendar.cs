using System;
using System.Collections;
using System.Collections.Generic;

public  class WeeklyCalendar:IWeeklyCalendar
    {
        public WeeklyCalendar()
        {
            this.WeeklySchedule = new List<WeeklyEntry>();
        }
        
        public List<WeeklyEntry> WeeklySchedule{ get; }

       
        public void AddEntry(string weekday, string notes)
        {
            this.WeeklySchedule.Add(new WeeklyEntry(weekday, notes));
        }

        IEnumerable<IWeeklyEntry> IWeeklyCalendar.WeeklySchedule { get; set; }


        public IEnumerator<IWeeklyEntry> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

