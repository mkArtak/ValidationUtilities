using System;
using Xunit;

namespace AM.Common.Validation.Tests
{
    public class StringValidationExtensionsTests
    {
        #region IsNotNullOrEmpty tests
        [Fact]
        public void IsNotNullOrEmpty_ThrowsForNullArgument()
        {
            string value = null;

            Assert.Throws<ArgumentNullException>(() => value.Ensure<string>().IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_ThrowsForEmptyArgument()
        {
            string value = string.Empty;
            Assert.Throws<ArgumentException>(() => value.Ensure<string>().IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_Succeeds()
        {
            string value = "dummy String";

            value.Ensure<string>().IsNotNullOrEmpty();
        }
        #endregion

        #region IsNotNullOrWhitespace tests
        [Fact]
        public void IsNotNullOrWhitespace_ThrowsForNullArgument()
        {
            string value = null;

            Assert.Throws<ArgumentException>(() => value.Ensure<string>().IsNotNullOrWhitespace());
        }

        [Fact]
        public void IsNotNullOrWhitespace_ThrowsForEmptyArgument()
        {
            string value = string.Empty;
            Assert.Throws<ArgumentException>(() => value.Ensure<string>().IsNotNullOrWhitespace());
        }

        [Fact]
        public void IsNotNullOrWhitespace_ThrowsForWhitespaceArgument()
        {
            string value = "  \n\r\t";

            Assert.Throws<ArgumentException>(() => value.Ensure<string>().IsNotNullOrWhitespace());
        }

        [Fact]
        public void IsNotNullOrWhitespace_Succeeds()
        {
            string value = "fake string value";

            value.Ensure<string>().IsNotNullOrWhitespace();
        }
        #endregion

        [Fact]
        public void Fluent_Succeeds()
        {
            string value = "testString";
            value.Ensure().IsNotNull().IsNotNullOrEmpty();
        }

        [Fact]
        public void IsNotEmpty_Succeeds()
        {
            string value = "testString";

            value.Ensure().IsNotEmpty();
        }

        [Fact]
        public void IsNotEmpty_ThrowsForEmptyStringWithoutParameterName()
        {
            string value = String.Empty;

            Assert.Throws<ArgumentException>(() => value.Ensure().IsNotEmpty());
        }

        [Fact]
        public void IsNotEmpty_ThrowsForEmptyStringWithParameterName()
        {
            string value = String.Empty;

            ArgumentException aex = Assert.Throws<ArgumentException>(() => value.Ensure(nameof(value)).IsNotEmpty());
            Assert.Equal(nameof(value), aex.ParamName);
        }

        [Fact]
        public void IsNotEmpty_ThrowsErrorWithSpecifiedMessage()
        {
            string value = String.Empty;
            const string errorMessage = "fake error message";

            ArgumentException aex = Assert.Throws<ArgumentException>(() => value.Ensure(nameof(value)).IsNotEmpty(errorMessage));
            Assert.Equal(nameof(value), aex.ParamName);
            Assert.Contains(errorMessage, aex.Message);
        }
    }
}
