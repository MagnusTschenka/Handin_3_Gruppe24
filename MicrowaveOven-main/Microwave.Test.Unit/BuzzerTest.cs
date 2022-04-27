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
            // We don't need an assert, as an exception would fail the test case

            //arrange
            var expected = "BUZZ, BUZZ, BUZZ\r\n";
            var stringwriter = new StringWriter();
            Console.SetOut(stringwriter);

            //act
            uut.StartBuzzing();

            //assert
            Assert.AreEqual(expected, stringwriter.ToString());

        }
    }
}