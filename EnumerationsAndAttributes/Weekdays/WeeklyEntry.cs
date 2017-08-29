using System;

public class WeeklyEntry : IWeeklyEntry
{
    private WeekDay weekDay;
    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekDay);
        this.Notes = notes;
    }



    public WeekDay Weekday => this.weekDay;

    public string Notes { get; private set; }




    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var weekDayComprison = weekDay.CompareTo(other.weekDay);
        return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.weekDay} - {this.Notes} ";
    }



    

}




