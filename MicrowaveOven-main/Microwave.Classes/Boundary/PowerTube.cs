using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private IOutput myOutput;
        public int Power { get; private set; }
        private bool IsOn = false;

        public PowerTube(IOutput output, int power)
        {
            myOutput = output;
            Power = (power >= 500 && power <= 1000)? power : 500;
        }

        public void TurnOn()
        {
            //if (Power < 500 || 1000 < Power)
            //{
            //    throw new ArgumentOutOfRangeException("power", Power, "Must be between 500 and 1000 (incl.)");
            //}

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {Power}");
            IsOn = true;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                myOutput.OutputLine($"PowerTube turned off");
            }

            IsOn = false;
        }
    }
}