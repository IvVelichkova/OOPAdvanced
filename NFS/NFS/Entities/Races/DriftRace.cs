
using System.Linq;
using System.Text;

public class DriftRace : Race
{
    private int suspensionPerformance;
    private int durability;
    public DriftRace(int lenght, string route, int prizePool) : base(lenght, route, prizePool)
    {
    }

  
    
    public override string GetPerformance()
    {
        int count = 1;
        var sb = new StringBuilder();
        var winners = base.participants.OrderByDescending(n => n.Value.SuspensionPerformance()).Take(3).ToDictionary(m => m.Key, k => k.Value);

        sb.AppendLine($"{base.Route} - {base.Lenght}");
        foreach (var winn in winners)
        {
            if (count == 1)
            {
                sb.AppendLine(
                    $"{count}. {winn.Value.Brand} {winn.Value.Model} {winn.Value.SuspensionPerformance()}PP - ${(base.PrizePool * 50) / 100}");

            }
            if (count == 2)
            {
                sb.AppendLine(
                    $"{count}. {winn.Value.Brand} {winn.Value.Model} {winn.Value.SuspensionPerformance()}PP - ${(base.PrizePool * 30) / 100}");

            }
            if (count == 3)
            {
                sb.AppendLine(
                    $"{count}. {winn.Value.Brand} {winn.Value.Model} {winn.Value.SuspensionPerformance()}PP - ${(base.PrizePool * 20) / 100}");

            }
            count++;
        }
        return sb.ToString().Trim();
    }
}

