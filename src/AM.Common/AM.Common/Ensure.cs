using System;

namespace AM.Common.ValidationFramework
{
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
