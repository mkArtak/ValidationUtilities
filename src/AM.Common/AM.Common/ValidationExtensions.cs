using System;

namespace AM.Common.ValidationFramework
{
    public static class ValidationExtensions
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

        public static Ensure<string> IsNotNullOrEmpty(this Ensure<string> context)
        {
            if (String.IsNullOrEmpty(context.ParameterValue))
            {
                throw new ArgumentException();
            }

            return context;
        }
    }
}
