using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
         
        private const int MinwWight = 1;
        private const int MaxWeight = 200;
        public Dough(string flourType,string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < MinwWight || value > MaxWeight)
                {
                    throw new AccessViolationException($"Dough weight should be in the range[{MinwWight}..{MaxWeight}].");
                }
                weight = value;
            }
        }


        public string BakingTechnique
        {
            get { return bakingTechnique; }

            set
            {
                if (value.ToLower() != "crispy" || value.ToLower() != "chewy" || value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        public string FlourType
        {
            get { return flourType; }

            private set
            {
                if (value.ToLower() != "wholegrain" || value.ToLower() != "white")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

    }
}
