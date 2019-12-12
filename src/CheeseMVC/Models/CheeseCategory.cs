using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseCategory
    {
        public double ID;

        public double GetID()
        {
            return ID;
        }

        public void SetID(double value)
        {
            ID = value;
        }

        public string Name { get; set; }

    }
}
