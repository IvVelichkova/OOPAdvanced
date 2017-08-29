using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_Data
{
    public class Tire
    {
        private int age;
        private double pressure;

        public Tire(int age, double pressure)
        {
            this.age = age;
            this.pressure = pressure;
        }

        public double Pressure
        {
            get { return this.pressure; }
        }
    }
}
