using Microwave.Classes.Boundary;
using Microwave.Classes.Interfaces;
using NSubstitute;
using NUnit.Framework;
using System.IO;
using System;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class BuzzerTest
    {
        private Buzzer uut;
        private IOutput SoundOutput;

        [SetUp]
        public void Setup()
        {
            SoundOutput = Substitute.For<IOutput>();
            uut = new Buzzer(SoundOutput);
        }

        [Test]
        public void Buzzer_StartBuzzing_CorrectBuzz()
        {
            uut.StartBuzzing();
            SoundOutput.Received(1).OutputLine(Arg.Is<string>(str => str.Contains("BUZZ, BUZZ, BUZZ")));

        }

    }

}