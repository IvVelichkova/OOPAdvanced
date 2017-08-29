using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        //damage, health and armor.
        //health 250, damage 45, and armor 10.
        private  const  int damageDef = 45;
        private  const int healthDef = 250;
        private const int armorDef = 10;
        public static void Main(string[] args)
        {

            var dragon = new Dictionary<string, Dictionary<string, int[]>>();
            var n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i <n; i++)
            {
               var input = Console.ReadLine().Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = input[0];
                string name = input[1];
                int damage = 0;
                if (!int.TryParse(input[2], out damage))
                {
                    damage = damageDef;
                }
                int health = 0;
                if (!int.TryParse(input[3],out health))
                {
                    health = healthDef;
                }
                int armor = 0;
                if (!int.TryParse(input[4], out armor))
                {
                    armor = armorDef;
                }
                if (!dragon.ContainsKey(type))
                {
                    dragon.Add(type, new Dictionary<string, int[]>());
                }
                if (!dragon[type].ContainsKey(name))
                {
                    dragon[type].Add(name, new int[3] {damage,health,armor});
                }
                else
                {
                    dragon[type][name] = new int[3] {damage, health, armor};
                }
            }
            foreach (var dr in dragon)
            {

                var sb = new StringBuilder();

               double avgDmg = 0;
               double avgHLT = 0;
               double avgARM = 0;

                foreach (var t in dr.Value.OrderBy(m=>m.Key))
                {
                    avgDmg += t.Value[0];
                    avgHLT += t.Value[1];
                    avgARM += t.Value[2];
                    sb.AppendLine($"-{t.Key} -> damage: {t.Value[0]}, health: {t.Value[1]}, armor: {t.Value[2]}");
                }
                avgDmg = avgDmg / dr.Value.Count;
                avgHLT = avgHLT / dr.Value.Count;
                avgARM = avgARM / dr.Value.Count;
                Console.WriteLine($"{dr.Key}::({avgDmg:F2}/{avgHLT:f2}/{avgARM:f2})");
                Console.WriteLine(sb.ToString().Trim());
            }


        }
    }
}
