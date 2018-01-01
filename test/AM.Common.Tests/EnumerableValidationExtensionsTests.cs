using System;
using System.Collections.Generic;
using Xunit;

namespace AM.Common.Validation.Tests
{
    public class EnumerableValidationExtensionsTests
    {
        [Fact]
        public void IsNotEmptyEnumerable_ThrowsForEmptyEnumerable()
        {
            IEnumerable<object> items = new object[] { };
            Assert.Throws<ArgumentException>(() => items.Ensure().IsNotEmptyEnumerable());
        }

        [Fact]
        public void IsNotEmptyEnumerable_Succeeds()
        {
            IEnumerable<object> items = new object[] { new object() };
            items.Ensure().IsNotEmptyEnumerable();
        }

        [Fact]
        public void IsNotEmptyEnumerable_ExceptionHasParamName()
        {
            const string testParamName = "testParam";

            IEnumerable<object> obj = new object[] { };

            ArgumentException ex = Assert.Throws<ArgumentException>(() => obj.Ensure(testParamName).IsNotEmptyEnumerable());

            Assert.Equal(testParamName, ex.ParamName);
        }
    }
}