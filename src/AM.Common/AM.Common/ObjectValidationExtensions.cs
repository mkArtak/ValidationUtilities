using System;

namespace AM.Common.ValidationFramework
{
    public static class ObjectValidationExtensions
    {
        public static Ensure<T> Ensure<T>(this T parameter)
        {
            return new Ensure<T>(parameter);
        }

        public static Ensure<T> IsNotNull<T>(this Ensure<T> context) where T : class
        {
            if (context.ParameterValue == null)
            {
                throw new ArgumentNullException();
            }

            return context;
        }
    }
}
