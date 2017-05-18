using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
