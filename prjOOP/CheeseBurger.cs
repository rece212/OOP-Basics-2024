using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    public class CheeseBurger :Burger
    {
        public String Cheese = "Cheese";
        public String getCheese()
        {
            return Cheese; 
        }
        public String AddCheddar()
        {
            this.Cheese = "Cheddar";
            return this.Cheese;
        }

    }
}
