using Microwave.Classes.Boundary;
using Microwave.Classes.Interfaces;
using NSubstitute;
using NSubstitute.Core.Arguments;
using NUnit.Framework;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class PowerTubeTest
    {
        private PowerTube uut;
        private IOutput output;

        [SetUp]
        public void Setup()
        {
            output = Substitute.For<IOutput>();
            uut = new PowerTube(output, 500);
        }

        //[TestCase(1)]
        //[TestCase(50)]
        //[TestCase(100)]
        //[TestCase(699)]
        //[TestCase(700)]
        //public void TurnOn_WasOffCorrectPower_CorrectOutput(Configuration power)
        //{
        //    uut.TurnOn();
        //    output.Received().OutputLine(Arg.Is<string>(str => str.Contains($"{power}")));
        //}

        //[TestCase(-5)]
        //[TestCase(-1)]
        //[TestCase(0)]
        //[TestCase(701)]
        //[TestCase(750)]
        //public void TurnOn_WasOffOutOfRangePower_ThrowsException(Configuration power)
        //{
        //    Assert.Throws<System.ArgumentOutOfRangeException>(() => uut.TurnOn());
        //}
        [TestCase(400, 500)]
        [TestCase(1200, 500)]
        [TestCase(690, 690)]
        [Test]
        public void ctor_PowerTube_Power_Under_Between_Outside_AcceptableRange(int argument, int expected)
        {
            PowerTube Temp_uut = new PowerTube(output, argument);
            Assert.That(Temp_uut.Power, Is.EqualTo(expected));
        }
        

        [Test]
        public void TurnOff_WasOn_CorrectOutput()
        {
            uut.TurnOn();
            uut.TurnOff();
            output.Received().OutputLine(Arg.Is<string>(str => str.Contains("off")));
        }

        [Test]
        public void TurnOff_WasOff_NoOutput()
        {
            uut.TurnOff();
            output.DidNotReceive().OutputLine(Arg.Any<string>());
        }

        [Test]
        public void TurnOn_WasOn_ThrowsException()
        {
            uut.TurnOn();
            Assert.Throws<System.ApplicationException>(() => uut.TurnOn());
        }
    }
}