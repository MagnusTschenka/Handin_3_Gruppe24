using System;
using System.Collections.Generic;
using System.Text;

namespace Microwave.Classes.Interfaces
{
    public abstract class Configuration
    {
        public int Power { get; set; }
        public abstract void ConfigurationInterface();
    }
}
