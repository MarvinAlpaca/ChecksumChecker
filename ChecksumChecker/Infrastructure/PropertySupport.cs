///
/// This file was taken from the In the Box MVVM training extension
/// http://visualstudiogallery.msdn.microsoft.com/3ab5f02f-0c54-453c-b437-8e8d57eb9942/
///

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace ChecksumChecker.Infrastructure
{
    public static class PropertySupport
    {
        public static String ExtractPropertyName<T>(Expression<Func<T>> propertyExpresssion)
        {
            if (propertyExpresssion == null)
            {
                throw new ArgumentNullException("propertyExpresssion");
            }

            var memberExpression = propertyExpresssion.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new ArgumentException("The expression is not a member access expression.", "propertyExpresssion");
            }

            var property = memberExpression.Member as PropertyInfo;
            if (property == null)
            {
                throw new ArgumentException("The member access expression does not access a property.", "propertyExpresssion");
            }

            var getMethod = property.GetGetMethod(true);
            if (getMethod.IsStatic)
            {
                throw new ArgumentException("The referenced property is a static property.", "propertyExpresssion");
            }

            return memberExpression.Member.Name;
        }
    }
}