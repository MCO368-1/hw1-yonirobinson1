using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Travis1CSharp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Travis1CSharp.Program.True());
        }
    }
}
