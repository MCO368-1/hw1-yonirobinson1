using System;
using NUnit.Framework;

namespace Travis1CSharp.Test
{
    public class UnitTest1
    {
        [Test]
        public void TestMethod0()
        {
            Assert.IsTrue(Travis1CSharp.Program.True());
        }
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Travis1CSharp.Program.True());
        }
        [Test]
        public void TestMethod2()
        {
            Assert.IsTrue(Travis1CSharp.Program.True());
        }
        [Test]
        public void TestMethod3()
        {
            Assert.IsTrue(!Travis1CSharp.Program.True());
        }
    }
}
