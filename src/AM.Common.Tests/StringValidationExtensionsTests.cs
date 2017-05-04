using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AM.Common.ValidationFramework.Tests
{
    [TestClass]
    public class StringValidationExtensionsTests
    {
        #region IsNotNullOrEmpty tests
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNotNullOrEmpty_ThrowsForNullArgument()
        {
            string value = null;
            value.Ensure<string>().IsNotNullOrEmpty();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNotNullOrEmpty_ThrowsForEmptyArgument()
        {
            string value = string.Empty;
            value.Ensure<string>().IsNotNullOrEmpty();
        }

        [TestMethod]
        public void IsNotNullOrEmpty_Succeeds()
        {
            string value = "dummy String";

            value.Ensure<string>().IsNotNullOrEmpty();
        }
        #endregion

        #region IsNotNullOrWhitespace tests
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNotNullOrWhitespace_ThrowsForNullArgument()
        {
            string value = null;
            value.Ensure<string>().IsNotNullOrWhitespace();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNotNullOrWhitespace_ThrowsForEmptyArgument()
        {
            string value = string.Empty;
            value.Ensure<string>().IsNotNullOrWhitespace();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNotNullOrWhitespace_ThrowsForWhitespaceArgument()
        {
            string value = "  \n\r\t";
            value.Ensure<string>().IsNotNullOrWhitespace();
        }

        [TestMethod]
        public void IsNotNullOrWhitespace_Succeeds()
        {
            string value = "fake string value";

            value.Ensure<string>().IsNotNullOrWhitespace();
        }
        #endregion

        [TestMethod]
        public void Fluent_Succeeds()
        {
            string value = "testString";
            value.Ensure().IsNotNull().IsNotNullOrEmpty();
        }
    }
}
