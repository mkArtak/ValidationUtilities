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

        [Fact]
        public void IsValidIndex_ThrowsForNullEnumerable()
        {
            IEnumerable<object> obj = null;

            ArgumentNullException aex = Assert.Throws<ArgumentNullException>(() => obj.Ensure(nameof(obj)).IsValidIndex(0));

            Assert.Equal(nameof(obj), aex.ParamName);
        }

        [Fact]
        public void IsValidIndex_ThrowsForEmptyEnumerable()
        {
            IEnumerable<object> obj = Array.Empty<object>();

            ArgumentException aex = Assert.Throws<ArgumentException>(() => obj.Ensure(nameof(obj)).IsValidIndex(0));

            Assert.Equal(nameof(obj), aex.ParamName);
        }

        [Fact]
        public void IsValidIndex_ThrowsForLessThanZeroIndex()
        {
            IEnumerable<object> obj = new object[] { 1 };

            ArgumentOutOfRangeException aex = Assert.Throws<ArgumentOutOfRangeException>(() => obj.Ensure(nameof(obj)).IsValidIndex(-1));

            Assert.Equal(nameof(obj), aex.ParamName);
        }

        [Fact]
        public void IsValidIndex_ThrowsForIndexGreaterThanSize()
        {
            IEnumerable<object> obj = new object[] { 1 };

            ArgumentOutOfRangeException aex = Assert.Throws<ArgumentOutOfRangeException>(() => obj.Ensure(nameof(obj)).IsValidIndex(1));

            Assert.Equal(nameof(obj), aex.ParamName);
        }

        [Fact]
        public void IsValidIndex_Succeeds()
        {
            IEnumerable<object> obj = new object[] { 1 };

            obj.Ensure(nameof(obj)).IsValidIndex(0);
        }
    }
}