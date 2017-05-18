using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Facade.FamilyCinema
{

    public class CDPlayer
    {
        public Amplifier Amplifier { get; set; }

        public void On() { }

        public void Off() { }

        public void Eject() { }

        public void Pause() { }

        public void Play() { }

        public void Stop() { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
