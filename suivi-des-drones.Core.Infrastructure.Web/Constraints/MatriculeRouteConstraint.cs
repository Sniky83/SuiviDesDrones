using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suivi_des_drones.Core.Infrastructure.Web.Constraints
{
    public class MatriculeRouteConstraint : IRouteConstraint
    {
        #region Public Methods
        //matconst
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            bool isValid = false;

            object value = values[routeKey];

            isValid = (value != null) && value.ToString().Length > 5;

            return isValid;
        }
        #endregion
    }
}
