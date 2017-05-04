using System;

namespace AM.Common.ValidationFramework
{
    public static class StringValidationExtensions
    {
        public static Ensure<string> IsNotNullOrEmpty(this Ensure<string> context)
        {
            if (String.IsNullOrEmpty(context.ParameterValue))
            {
                throw new ArgumentException();
            }

            return context;
        }

        public static Ensure<string> IsNotNullOrWhitespace(this Ensure<string> context)
        {
            if (String.IsNullOrWhiteSpace(context.ParameterValue))
            {
                throw new ArgumentException();
            }

            return context;
        }
    }
}
