using System;
using System.Collections.Generic;
using Xunit;

namespace AM.Common.ValidationFramework.Tests
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

            ArgumentException ex = Assert.Throws<ArgumentException>(() =>
            {
                IEnumerable<object> obj = new object[] { };
                obj.Ensure().IsNotEmptyEnumerable(testParamName);
            });

            Assert.Equal(testParamName, ex.ParamName);
        }
    }
}