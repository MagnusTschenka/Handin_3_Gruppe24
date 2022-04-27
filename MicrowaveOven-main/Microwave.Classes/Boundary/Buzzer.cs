using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class Buzzer : IBuzzer
    {
        private IOutput SoundOutput;

        public Buzzer(IOutput soundOutput)
        {
            SoundOutput = soundOutput;
        }

        public void StartBuzzing()
        {
            SoundOutput.OutputLine("BUZZ, BUZZ, BUZZ");
            //Console.WriteLine("BUZZ, BUZZ, BUZZ");
        }
    }
}
