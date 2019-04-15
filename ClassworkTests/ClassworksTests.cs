using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork.Tests
{
    [TestClass()]
    public class ClassworksTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            Assert.AreEqual("boj" ,Classworks.Reverse("job"));
        }

        [TestMethod]
        public void CheckPattern()
        {
            Assert.AreEqual(true, Bowling.check(136));
            Assert.AreEqual(true, Bowling.check(1));
            Assert.AreEqual(false, Bowling.check(4));
            Assert.AreEqual(false, Bowling.check(517351397));
            Assert.AreEqual(true, Bowling.check(21));
        }
    }
}