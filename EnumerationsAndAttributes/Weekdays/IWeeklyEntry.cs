using System;
public interface IWeeklyEntry : IComparable<WeeklyEntry>
{

    WeekDay Weekday { get; }
    string Notes { get; }


    //IComparable<WeeklyEntry> 
}

