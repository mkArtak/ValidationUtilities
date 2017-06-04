using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AM.Common.ValidationFramework.Tests
{
    [TestClass]
    public class ObjectValidationExtensionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsNotNull_ThrowsNullReferenceException()
        {
            object value = null;
            value.Ensure().IsNotNull();
        }

        [TestMethod]
        public void IsNotNull_Succeeds()
        {
            object value = new object();
            value.Ensure().IsNotNull();
        }

        [TestMethod]
        public void IsNotNull_ExceptionHasParamName()
        {
            const string testParamName = "testParam";

            try
            {
                object obj = null;
                obj.Ensure().IsNotNull(testParamName);
                Assert.Fail();
            }
            catch (ArgumentException aex)
            {
                Assert.AreEqual(testParamName, aex.ParamName);
            }
        }
    }
}
