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
        public void StartBuzzing()
        {
            Console.WriteLine("BUZZ, BUZZ, BUZZ");
        }
    }
}
