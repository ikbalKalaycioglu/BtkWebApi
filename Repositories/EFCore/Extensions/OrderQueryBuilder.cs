using Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Extensions
{
    public static class OrderQueryBuilder
    {
        public static String CreateOrderQuery<T>(String sortTerm)
        {
            var orderParams = sortTerm.Trim().Split(",");

            var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();
            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var poropertyFromQueryName = param.Split(" ")[0];

                var objectPropery = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(poropertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectPropery is null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";

                orderQueryBuilder.Append($"{objectPropery.Name.ToString()} {direction},");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
            return orderQuery;

        }
    }
}
