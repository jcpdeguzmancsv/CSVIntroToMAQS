using CognizantSoftvision.Maqs.BaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// Test1 test class
    /// </summary>
    [TestClass]
    public class ExtraVSUnitTest : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void SampleTest()
        {
            this.Log.LogMessage("Sample Test");
            Assert.IsTrue(true, "true Is Not TRUE");
        }

        [TestMethod]
        public void ExtraFunkyTest()
        {
            this.Log.LogMessage("Funky Test - Session 1");

            Assert.IsTrue(true, "true Is Not TRUE");
        }
    }
}
