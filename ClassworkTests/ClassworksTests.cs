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
    }
}