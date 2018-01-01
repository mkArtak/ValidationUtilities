using System;
using Xunit;

namespace AM.Common.Validation.Tests
{
    public class ObjectValidationExtensionsTests
    {
        [Fact]
        public void IsNotNull_ThrowsNullReferenceException()
        {
            object value = null;

            Assert.Throws<ArgumentNullException>(() => value.Ensure().IsNotNull());
        }

        [Fact]
        public void IsNotNull_Succeeds()
        {
            object value = new object();
            value.Ensure().IsNotNull();
        }

        [Fact]
        public void IsNotNull_ExceptionHasParamName()
        {
            const string testParamName = "testParam";
            object obj = null;

            ArgumentNullException aex = Assert.Throws<ArgumentNullException>(() => obj.Ensure(testParamName).IsNotNull());

            Assert.Equal(testParamName, aex.ParamName);
        }
    }
}
