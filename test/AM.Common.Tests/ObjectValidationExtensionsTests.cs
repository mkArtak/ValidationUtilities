using System;
using Xunit;

namespace AM.Common.ValidationFramework.Tests
{
    public class ObjectValidationExtensionsTests
    {
        [Fact]
        public void IsNotNull_ThrowsNullReferenceException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                object value = null;
                value.Ensure().IsNotNull();
            });
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

            ArgumentNullException aex = Assert.Throws<ArgumentNullException>(() =>
            {
                object obj = null;
                obj.Ensure().IsNotNull(testParamName);
            });

            Assert.Equal(testParamName, aex.ParamName);
        }
    }
}
