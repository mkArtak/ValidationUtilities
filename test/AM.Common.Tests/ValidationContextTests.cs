using System;
using Xunit;

namespace AM.Common.Validation.Tests
{
    public class ValidationContextTests
    {
        [InlineData(77)]
        [InlineData("testValue")]
        [Theory]
        public void Value_IsTheSameWhichPropertyHas<T>(T value)
        {
            Assert.Equal(value, value.Ensure().Value);
        }

        [Fact]
        public void ParameterName_IsTheSameWhichPropertyHas()
        {
            const string expected = "testParam";
            string value = "test";
            Assert.Equal(expected, value.Ensure(expected).ParameterName);
        }

        [Fact]
        public void Ensure_ForPropertyExpression()
        {
            Tuple<string, string> test = new Tuple<string, string>("str1", "str2");
            IValidationContext<string> context = test.Ensure(o => o.Item1);

            Assert.Equal(test.Item1, context.Value);
            Assert.Equal(nameof(test.Item1), context.ParameterName);
        }
    }
}
