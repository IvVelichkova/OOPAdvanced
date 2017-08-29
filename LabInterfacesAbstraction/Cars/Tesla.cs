using System;
using System.Text;

class Tesla : ICar, IElectricCar
{
    private string model;
    private string color;
    private int battery;
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Battery { get; private set; }


    public string Start()
    {
        return "Engine start";
    }
    public string Stop()
    {
        return "Breaaak !";
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        //Red Tesla Model 3 with 2 Batteries       
        sb.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries");
        sb.AppendLine(Start());
        sb.Append(Stop());

        return sb.ToString();
    }
}

