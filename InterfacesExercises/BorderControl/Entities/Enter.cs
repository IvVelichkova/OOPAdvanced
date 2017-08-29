using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Entities
{
    class Enter:ICitizen,IRobot
    {
        private int id;

        public Enter(int Id)
        {
            this.Id = id;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name { get; }
        
        public int Age { get; }
       
        public string Model { get; }
        
    }
}
