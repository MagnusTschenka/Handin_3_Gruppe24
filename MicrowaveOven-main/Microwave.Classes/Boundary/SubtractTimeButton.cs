using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class SubtractTimeButton : IButton
    {
       public SubtractTimeButton(ITimer timer)
        { itimer = timer; }

        public ITimer itimer;
        public event EventHandler Pressed;

        public void Press()
        {
            Pressed?.Invoke(this, EventArgs.Empty);

        }
    }
}
