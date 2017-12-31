namespace AM.Common.ValidationFramework
{
    /// <summary>
    /// Represents the validaiton context.
    /// </summary>
    /// <typeparam name="T">The type parameter of the argument tp be validated.</typeparam>
    public sealed class ValidationContext<T>
    {
        private T value;

        private readonly string paramName;

        /// <summary>
        /// Gets the value of the parameter being validated
        /// </summary>
        public T Value { get => this.value; }

        internal string ParameterName { get => this.paramName; }

        internal ValidationContext(T parameterValue, string parameterName = null)
        {
            this.value = parameterValue;
            this.paramName = parameterName;
        }
    }
}
