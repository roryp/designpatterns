using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{
    public class Mocha : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
            this.Description = Beverage.Description + ", Mocha";
        }

        public override double Cost()
        {
            return 0.20 + Beverage.Cost();
        }
    }
}
