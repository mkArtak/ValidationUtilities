using System;
using System.Collections.Generic;
using System.Linq;

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
        public static ValidationContext<IEnumerable<T>> IsNotEmptyEnumerable<T>(this ValidationContext<IEnumerable<T>> context)
        {
            context.IsNotNull();

            if (!context.Value.Any())
            {
                throw new ArgumentException("Enumeration contains no elements", context.ParameterName);
            }

            return context;
        }
    }
}
