using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{

    public class Decat : Beverage
    {
        public Decat()
        {
            this.Description = "Decat Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
