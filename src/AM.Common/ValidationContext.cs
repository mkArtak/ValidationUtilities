namespace AM.Common.Validation
{
    /// <summary>
    /// Represents the validaiton context associated to a specific argument.
    /// </summary>
    /// <typeparam name="T">The type parameter of the argument tp be validated.</typeparam>
    internal sealed class ValidationContext<T> : IValidationContext<T>
    {
        /// <summary>
        /// Gets the value of the parameter being validated
        /// </summary>
        public T Value { get; }

        public string ParameterName { get; }

        internal ValidationContext(T parameterValue, string parameterName = null)
        {
            this.Value = parameterValue;
            this.ParameterName = parameterName;
        }
    }
}
