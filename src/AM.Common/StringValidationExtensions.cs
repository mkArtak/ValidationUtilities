using System;
using System.Runtime.CompilerServices;

namespace AM.Common.Validation
{
    public static class StringValidationExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IValidationContext<string> IsNotNullOrEmpty(this IValidationContext<string> context, string errorMessage = null)
        {
            return context.IsNotNull().IsNotEmpty(errorMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IValidationContext<string> IsNotNullOrWhitespace(this IValidationContext<string> context, string errorMessage = null)
        {
            if (String.IsNullOrWhiteSpace(context.Value))
            {
                throw GetArgumentExceptionToThrow(context.ParameterName, errorMessage);
            }

            return context;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IValidationContext<string> IsNotEmpty(this IValidationContext<string> context, string errorMessage = null)
        {
            if (context.Value == string.Empty)
            {
                throw GetArgumentExceptionToThrow(context.ParameterName, errorMessage);
            }

            return context;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static ArgumentException GetArgumentExceptionToThrow(string parameterName, string errorMessage)
        {
            return new ArgumentException(errorMessage, parameterName);
        }
    }
}