using System;

namespace AM.Common.ValidationFramework
{
    public static class ObjectValidationExtensions
    {
        public static Ensure<T> Ensure<T>(this T parameter, string parameterName = null)
        {
            return new Ensure<T>(parameter, parameterName);
        }

        public static Ensure<T> IsNotNull<T>(this Ensure<T> context) where T : class
        {
            if (context.ParameterValue == null)
            {
                throw new ArgumentNullException(context.ParameterName);
            }

            return context;
        }
    }
}
