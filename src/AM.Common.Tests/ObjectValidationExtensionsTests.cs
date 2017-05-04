using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
