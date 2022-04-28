using System;
using System.Threading;
using Microwave.Classes.Boundary;
using Microwave.Classes.Controllers;

namespace Microwave.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Button startCancelButton = new Button();
            Button powerButton = new Button();
            Button timeButton = new Button();
        
            Door door = new Door();

            Output output = new Output();

            Buzzer buzzer = new Buzzer(output);

            Display display = new Display(output);
            Console.WriteLine("Input max power for the powertube. Valid range is 500-1200");
            int power = Convert.ToInt16(Console.ReadLine());
            if (power <= 500 && power > 1200)
            {
                Console.WriteLine("Invalid input, power is set to max 50W");
                power = 50;
            }

            PowerTube powerTube = new PowerTube(output, power);

            Light light = new Light(output);

            Microwave.Classes.Boundary.Timer timer = new Microwave.Classes.Boundary.Timer();
            AddTimeButton addTimeButton = new AddTimeButton(timer);
            SubtractTimeButton subtractTimeButton = new SubtractTimeButton(timer);

            CookController cooker = new CookController(timer, display, powerTube); //, buzzer

            UserInterface ui = new UserInterface(addTimeButton,subtractTimeButton, powerButton, timeButton, startCancelButton, door, display, light, cooker, buzzer, powerTube);

            // Finish the double association
            cooker.UI = ui;

            // Simulate a simple sequence

            powerButton.Press();

            timeButton.Press();

            startCancelButton.Press();
            Thread.Sleep(3000);
            addTimeButton.Press();
            Thread.Sleep(3000);
            for (int i = 0; i < 12; i++)
            {
            subtractTimeButton.Press(); 

            }

            // The simple sequence should now run

            System.Console.WriteLine("When you press enter, the program will stop");
            // Wait for input

            System.Console.ReadLine();
        }
    }
}
