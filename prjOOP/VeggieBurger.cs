﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
     public class VeggieBurger :Burger
    {
        String mushroom = "Mushroom";
        public override string getPatty()
        {
            return mushroom;
        }
    }
}
