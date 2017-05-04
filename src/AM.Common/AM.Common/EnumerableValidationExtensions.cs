using System;
using System.Collections.Generic;
using System.Linq;

namespace AM.Common.ValidationFramework
{
    public static class EnumerableValidationExtensions
    {
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
