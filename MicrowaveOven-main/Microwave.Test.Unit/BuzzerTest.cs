using Microwave.Classes.Boundary;
using NUnit.Framework;
using System.IO;
using System;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class BuzzerTest
    {
        private Buzzer uut;

        [SetUp]
        public void Setup()
        {
            uut = new Buzzer();
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