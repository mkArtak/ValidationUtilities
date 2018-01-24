using System;

namespace AM.Common.Validation
{
    public static class ObjectValidationExtensions
    {
        public static IValidationContext<T> Ensure<T>(this T parameter, string parameterName = null)
        {
            return new ValidationContext<T>(parameter, parameterName);
        }

        public static IValidationContext<T> IsNotNull<T>(this IValidationContext<T> context) where T : class
        {
            if (context.Value == null)
            {
                throw new ArgumentNullException(context.ParameterName);
            }

            return context;
        }
    }
}
