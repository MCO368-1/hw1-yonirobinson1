using System;
using NUnit.Framework;

namespace Travis1CSharp.Test
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Travis1CSharp.Program.True()); 
        }
    }
}
