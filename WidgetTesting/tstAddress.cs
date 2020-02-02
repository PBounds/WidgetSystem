using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WidgetTesting
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we wnat to create
            clsAddress AnAddress = new clsAddress();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }
    }
}
