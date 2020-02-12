using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ECS.Legacy.Tests
{
    [TestFixture]
    public class ECSLegacyTests
    {
        private ECS ecs_uut;
        private Heater heater_uut;
        private TempSensor tempsens_uut;

        [SetUp]
        public void Setup()
        {
            heater_uut = new Heater();
            tempsens_uut = new TempSensor();
            ecs_uut = new ECS(20, new FakeTempSensor(), new FakeHeater());
        }

        [Test]
        public void HeaterTest()
        {
            Assert.That(heater_uut.RunSelfTest(), Is.True);
        }

        [Test]
        public void TempSensorTest()
        {
            Assert.That(tempsens_uut.RunSelfTest(), Is.True);
        }

        [Test]
        public void ECSFakeTest()
        {
            Assert.That(ecs_uut.RunSelfTest(), Is.True);
        }

        [TearDown]
        public void Teardown()
        {
            heater_uut = null;
            tempsens_uut = null;
            ecs_uut = null;
        }
    }
}
