using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AM.Common.ValidationFramework.Tests
{
    [TestClass]
    public class EnumerableValidationExtensionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsNotEmptyEnumerable_ThrowsForEmptyEnumerable()
        {
            IEnumerable<object> items = new object[] { };
            items.Ensure().IsNotEmptyEnumerable();
        }

        [TestMethod]
        public void IsNotEmptyEnumerable_Succeeds()
        {
            IEnumerable<object> items = new object[] { new object() };
            items.Ensure().IsNotEmptyEnumerable();
        }
    }
}
