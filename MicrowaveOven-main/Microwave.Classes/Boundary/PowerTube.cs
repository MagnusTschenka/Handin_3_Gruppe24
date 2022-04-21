using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private IOutput myOutput;

        private bool IsOn = false;

        private Configuration myConfiguration;

        public PowerTube(IOutput output)
        {
            myOutput = output;
        }

        public void TurnOn(Configuration configuration)
        {
            if (configuration.Power < 500 || 1000 < configuration.Power)
            {
                throw new ArgumentOutOfRangeException("power", configuration, "Must be between 500 and 1000 (incl.)");
            }

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {configuration}");
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