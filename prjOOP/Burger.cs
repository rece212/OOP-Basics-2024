using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    public abstract class Burger
    {
        private String patty = "Beef";
        private String bun = "Plain Wheat";

        public virtual String getPatty()
        {
            return patty;
        }
        public String getBun()
        {
            return bun;
        }
        public String getBun(String optionOne)
        {
            return optionOne ;
        }
        public String getBun(String optionOne, String optionTwo)
        {
            return optionOne + optionTwo;
        }

    }
}
