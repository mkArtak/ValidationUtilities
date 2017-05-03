using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AM.Common.ValidationFramework.Tests
{
    [TestClass]
    public class EnsureTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNull_ThrowsNullReferenceException()
        {
            object value = null;
            value.Ensure().IsNotNull();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullOrEmpty_ThrowsArgumentException()
        {
            string value = null;
            value.Ensure<string>().IsNotNullOrEmpty();
        }

        [TestMethod]
        public void Fluent_Succeeds()
        {
            string value = "testString";
            value.Ensure().IsNotNull().IsNotNullOrEmpty();
        }
    }
}
