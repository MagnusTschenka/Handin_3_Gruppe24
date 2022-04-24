using System;
using System.Collections.Generic;
using System.Text;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    
    public class Configuration500W : Configuration
    {
        public override void ConfigurationInterface()
        {
            Power = 500;
        }
    }

    public class Configuration700W : Configuration
    {
        public override void ConfigurationInterface()
        {
            Power = 700;
        }
    }

    public class Configuration800W : Configuration
    {
        public override void ConfigurationInterface()
        {
            Power = 800;
        }
    }

    public class Configuration1000W : Configuration
    {
        public override void ConfigurationInterface()
        {
            Power = 1000;
        }
    }
}
