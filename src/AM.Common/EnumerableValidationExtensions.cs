using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AM.Common.Validation
{
    public static class EnumerableValidationExtensions
    {
        /// <summary>
        /// Validates the specified <see cref="IEnumerable{T}" /> making sure it's not null or empty. 
        /// </summary>
        /// <typeparam name="T">The type parameter for the enumerable items.</typeparam>
        /// <param name="context">The context the validation will be happening in.</param>
        /// <returns>The validation context being validated.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IValidationContext<IEnumerable<T>> IsNotEmptyEnumerable<T>(this IValidationContext<IEnumerable<T>> context)
        {
            context.IsNotNull();

            if (!context.Value.Any())
            {
                throw new ArgumentException("Enumeration contains no elements", context.ParameterName);
            }

            return context;
        }

        /// <summary>
        /// Validates that the specified <see cref="index"/> is within the range of the enumerable being validated.
        /// </summary>
        /// <typeparam name="T">The type parameter for the enumerable items.</typeparam>
        /// <param name="context">The context the validation will be happening in.</param>
        /// <param name="index">The index to be validated.</param>
        /// <returns>The validation context being validated.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IValidationContext<IEnumerable<T>> IsValidIndex<T>(this IValidationContext<IEnumerable<T>> context, int index)
        {
            context.IsNotEmptyEnumerable();

            if (index < 0 || index >= context.Value.Count())
            {
                throw new ArgumentOutOfRangeException(context.ParameterName);
            }

            return context;
        }
    }
}
