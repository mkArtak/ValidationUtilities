using System;

namespace AM.Common.Validation
{
    public static class StringValidationExtensions
    {
        public static IValidationContext<string> IsNotNullOrEmpty(this IValidationContext<string> context, string errorMessage = null)
        {
            return context.IsNotNull().IsNotEmpty(errorMessage);
        }

        public static IValidationContext<string> IsNotNullOrWhitespace(this IValidationContext<string> context, string errorMessage = null)
        {
            if (String.IsNullOrWhiteSpace(context.Value))
            {
                throw GetArgumentExceptionToThrow(context.ParameterName, errorMessage);
            }

            return context;
        }

        public static IValidationContext<string> IsNotEmpty(this IValidationContext<string> context, string errorMessage = null)
        {
            if (context.Value == string.Empty)
            {
                throw GetArgumentExceptionToThrow(context.ParameterName, errorMessage);
            }

            return context;
        }

        private static ArgumentException GetArgumentExceptionToThrow(string parameterName, string errorMessage)
        {
            return new ArgumentException(errorMessage, parameterName);
        }
    }
}