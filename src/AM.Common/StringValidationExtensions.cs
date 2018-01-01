using System;

namespace AM.Common.ValidationFramework
{
    public static class StringValidationExtensions
    {
        public static ValidationContext<string> IsNotNullOrEmpty(this ValidationContext<string> context, string errorMessage = null)
        {
            return context.IsNotNull().IsNotEmpty(errorMessage);
        }

        public static ValidationContext<string> IsNotNullOrWhitespace(this ValidationContext<string> context, string errorMessage = null)
        {
            if (String.IsNullOrWhiteSpace(context.Value))
            {
                throw GetArgumentExceptionToThrow(context.ParameterName, errorMessage);
            }

            return context;
        }

        public static ValidationContext<string> IsNotEmpty(this ValidationContext<string> context, string errorMessage = null)
        {
            if (context.Value == string.Empty)
            {
                throw GetArgumentExceptionToThrow(context.ParameterName, errorMessage);
            }

            return context;
        }

        private static ArgumentException GetArgumentExceptionToThrow(string parameterName, string errorMessage)
        {
            //if (String.IsNullOrWhiteSpace(errorMessage))
            //{
            //  return new ArgumentException();
            //}

            return new ArgumentException(errorMessage, parameterName);
        }
    }
}