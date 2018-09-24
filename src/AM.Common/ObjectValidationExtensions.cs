using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace AM.Common.Validation
{
    public static class ObjectValidationExtensions
    {
        public static IValidationContext<T> Ensure<T>(this T parameter, string parameterName = null)
        {
            return new ValidationContext<T>(parameter, parameterName);
        }

        public static IValidationContext<TProperty> Ensure<TSource, TProperty>(this TSource source, Expression<Func<TSource, TProperty>> expr)
        {
            return new PropertyValidationContext<TSource, TProperty>(source, expr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
