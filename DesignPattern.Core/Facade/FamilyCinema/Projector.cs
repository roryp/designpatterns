using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Facade.FamilyCinema
{

    public class Projector
    {
        public DVDPlayer DVDPlayer { get; set; }

        public void On() { }

        public void Off() { }

        public void TVModel() { }

        public void WideScreenModel() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
