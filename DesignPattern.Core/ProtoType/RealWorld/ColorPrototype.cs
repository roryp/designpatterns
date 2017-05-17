﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.ProtoType.RealWorld
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
}
