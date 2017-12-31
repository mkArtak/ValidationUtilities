using System;

namespace AM.Common.ValidationFramework
{
    public static class StringValidationExtensions
    {
        public static ValidationContext<string> IsNotNullOrEmpty(this ValidationContext<string> context, string errorMessage = null)
        {
            if (String.IsNullOrEmpty(context.Value))
            {
                if (String.IsNullOrWhiteSpace(errorMessage))
                {
                    throw new ArgumentException();
                }

                throw new ArgumentException(errorMessage, context.ParameterName);
            }

            return context;
        }

        public static ValidationContext<string> IsNotNullOrWhitespace(this ValidationContext<string> context, string errorMessage = null)
        {
            if (String.IsNullOrWhiteSpace(context.Value))
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
