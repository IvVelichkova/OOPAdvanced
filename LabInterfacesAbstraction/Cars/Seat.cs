using System;
using System.Text;

public class Seat:ICar
{
    private string model;
    private string color;
    public Seat(string model,string color)
    {
        this.Model = model;
        this.Color = color;
    }
    public string Model { get; private set; }
    public string Color { get; private set; } 
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return"Breaaak !";
    }
    public override string ToString()
    {
        //Grey Seat Leon
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Seat {this.Model}");
        sb.AppendLine(Start());
        sb.Append(Stop());
        return sb.ToString();
    }
}

