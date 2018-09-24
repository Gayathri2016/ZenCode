using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZenCode;

namespace ZenTestCode
{
    [TestClass]
    public class UnitTest1
    {
        Algorithems al = new Algorithems();
        
        [TestMethod]
        public void CalMeanMedianMdeRangeTest()
        {
            var input = "1 2 3 6 4 5 6 7 7";
            try
            {

                al.CalMeanMedianMdeRange(input);
            }
            catch { Assert.IsTrue(false); }

        }
        [TestMethod]
        public void ReadStringTest()
        {
            var input = "thisis a samplestring";
            try
            {
                al.ReadString(input);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
