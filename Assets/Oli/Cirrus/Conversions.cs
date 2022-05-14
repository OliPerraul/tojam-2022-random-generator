using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cirrus
{
    public static class Convert_<TFrom, TTo>   
    {
        public static readonly Func<TFrom, TTo> Converter = _FromToConverter();

        private static Func<TFrom, TTo> _FromToConverter()
        {
            var parameter = Expression.Parameter(typeof(TFrom));
            var dynamicMethod = Expression.Lambda<Func<TFrom, TTo>>(
                Expression.Convert(parameter, typeof(TTo)),
                parameter);
            return dynamicMethod.Compile();
        }
    }
}
