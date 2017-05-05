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

        internal T ParameterValue { get => this.parameterValue; }

        internal Ensure(T parameterValue)
        {
            this.parameterValue = parameterValue;
        }
    }
}
