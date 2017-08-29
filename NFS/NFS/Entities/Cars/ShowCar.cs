
using System.Text;

public class ShowCar:Car
{
    private int stars;
    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.horsepower += tuneIndex;
        base.suspension += (tuneIndex * 50) / 100;
        this.stars += tuneIndex;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.AppendLine($"{stars} *");
        return sb.ToString().Trim();
    }
}

