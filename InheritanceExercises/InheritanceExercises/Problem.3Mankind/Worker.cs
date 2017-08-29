using System;



public class Worker:Human
{
    private decimal weekaSlary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastNAme) : base(firstName, lastNAme)
    {
        this.WeekaSlary = weekaSlary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekaSlary { get; set; }
    public decimal WorkHoursPerDay { get; set; }

}

