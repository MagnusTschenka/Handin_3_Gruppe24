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

            PowerTube powerTube = new PowerTube(output, 500);

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
