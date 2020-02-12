using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy.Tests
{
    public class FakeTempSensor : ITempSensor
    {
        private Random gen = new Random();
        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
