using System;
using System.Linq.Expressions;
using System.Reflection;

namespace AM.Common.Validation
{
    internal class PropertyValidationContext<TSource, TProperty> : IValidationContext<TProperty>
    {
        private readonly TSource source;
        private readonly PropertyInfo propertyInfo;

        public TProperty Value => (TProperty)this.propertyInfo.GetValue(source);
        public string ParameterName => this.propertyInfo.Name;

        internal PropertyValidationContext(TSource source, Expression<Func<TSource, TProperty>> propertyExpression)
        {
            this.source = source;
            this.propertyInfo = this.GetPropertyInfo(source, propertyExpression ?? throw new ArgumentNullException(nameof(propertyExpression)));
        }

        private PropertyInfo GetPropertyInfo(TSource instance, Expression<Func<TSource, TProperty>> propertyExpression)
        {
            MemberExpression mexp = propertyExpression.Body as MemberExpression;
            if (mexp == null)
            {
                throw new ArgumentException("Invalid");
            }
            PropertyInfo result = mexp.Member as PropertyInfo;
            if (result == null)
            {
                throw new ArgumentException("Invalid expression");
            }
            return result;
        }
    }
}
