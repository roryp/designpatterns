﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Decorate.Starbuzz
{

    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.Description = "Espresso Coffee";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
