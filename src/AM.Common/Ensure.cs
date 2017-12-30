using System;

namespace AM.Common.ValidationFramework
{
    /// <summary>
    /// Represents the validaiton context.
    /// </summary>
    /// <typeparam name="T">The type parameter of the argument tp be validated.</typeparam>
    public sealed class Ensure<T>
    {
        private T parameterValue;

        private readonly string paramName;

        internal T ParameterValue { get => this.parameterValue; }

        internal string ParameterName { get => this.paramName; }

        internal Ensure(T parameterValue, string parameterName = null)
        {
            this.parameterValue = parameterValue;
            this.paramName = parameterName;
        }
    }
}
