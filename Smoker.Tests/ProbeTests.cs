using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Smoker.Tests
{
    [TestClass]
    public class ProbeTests
    {
        [TestMethod]
        public void TestRoomTemp()
        {
            var roomtemp = Smoker.Probe.TempFromRawRead(.5);

            Assert.AreEqual(roomtemp, 77);
        }
    }
}
