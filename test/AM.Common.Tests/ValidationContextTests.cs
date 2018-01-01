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
    }
}
