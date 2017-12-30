using System;

namespace AM.Common.ValidationFramework
{
    public static class StringValidationExtensions
    {
        public static Ensure<string> IsNotNullOrEmpty(this Ensure<string> context, string errorMessage = null)
        {
            if (String.IsNullOrEmpty(context.ParameterValue))
            {
                if (String.IsNullOrWhiteSpace(errorMessage))
                {
                    throw new ArgumentException();
                }

                throw new ArgumentException(errorMessage, context.ParameterName);
            }

            return context;
        }

        public static Ensure<string> IsNotNullOrWhitespace(this Ensure<string> context, string errorMessage = null)
        {
            if (String.IsNullOrWhiteSpace(context.ParameterValue))
            {
                if (String.IsNullOrWhiteSpace(errorMessage))
                {
                    throw new ArgumentException();
                }

                throw new ArgumentException(errorMessage, context.ParameterName);
            }

            return context;
        }
    }
}
