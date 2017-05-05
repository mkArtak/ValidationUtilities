using System;
using System.Collections.Generic;
using System.Linq;

namespace AM.Common.ValidationFramework
{
    public static class EnumerableValidationExtensions
    {
        /// <summary>
        /// Validates the specified <see cref="IEnumerable{T}" /> making sure it's not null or empty. 
        /// </summary>
        /// <typeparam name="T">The type parameter for the enumerable items.</typeparam>
        /// <param name="context">The context the validation will be happening in.</param>
        /// <returns></returns>
        public static Ensure<IEnumerable<T>> IsNotEmptyEnumerable<T>(this Ensure<IEnumerable<T>> context)
        {
            context.IsNotNull();

            if (!context.ParameterValue.Any())
            {
                throw new ArgumentException("Enumeration contains no elements");
            }

            return context;
        }
    }
}
