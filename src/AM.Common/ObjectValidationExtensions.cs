using System;

namespace AM.Common.ValidationFramework
{
    public static class ObjectValidationExtensions
    {
        public static ValidationContext<T> Ensure<T>(this T parameter, string parameterName = null)
        {
            return new ValidationContext<T>(parameter, parameterName);
        }

        public static ValidationContext<T> IsNotNull<T>(this ValidationContext<T> context) where T : class
        {
            if (context.Value == null)
            {
                throw new ArgumentNullException(context.ParameterName);
            }

            return context;
        }
    }
}
