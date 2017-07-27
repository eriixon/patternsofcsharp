using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Singleton;

namespace Singlelton.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsSingleton()
        {
            var expected = Repository.Instance();
            var actual = Repository.Instance();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
