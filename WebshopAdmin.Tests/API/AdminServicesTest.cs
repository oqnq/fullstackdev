using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdminServices;

namespace WebshopAdmin.Tests.API
{
    [TestClass]
    public class AdminServicesTest
    {
        [TestMethod]
        public void ValidEmailTest()
        {
            Assert.IsTrue(GraphisoftEmailValidator.IsValid("sducsai@graphisoft.com"));
            Assert.IsTrue(GraphisoftEmailValidator.IsValid("sducsai2@graphisoft.com"));
            Assert.IsTrue(GraphisoftEmailValidator.IsValid("sducsai3@graphisoft.com"));
            Assert.IsTrue(GraphisoftEmailValidator.IsValid("sducsai3@graphisoft.com"));
        }
        [TestMethod]
        public void InvalidEmailTest()
        {
            Assert.IsFalse(GraphisoftEmailValidator.IsValid(""));
            Assert.IsFalse(GraphisoftEmailValidator.IsValid(null));
            Assert.IsFalse(GraphisoftEmailValidator.IsValid("ísducsai3@graphisoft.com"));
            Assert.IsFalse(GraphisoftEmailValidator.IsValid("barki@graphisoft.com"));
            Assert.IsFalse(GraphisoftEmailValidator.IsValid(@"ísd/:\\ai3@gr#&>ap\""hisoft.com"));
        }
        [TestMethod]
        public void MixedCaseTest()
        {
            Assert.IsTrue(GraphisoftEmailValidator.IsValid("sDucsAi3@graPHisoft.com"));
        }
    }
}
