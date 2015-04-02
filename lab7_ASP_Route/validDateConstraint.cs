using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;

namespace lab7_ASP_Route.App_Start
{
    class validDateConstraint:IRouteConstraint
    {

        public bool Match(System.Web.HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            DateTime dateValue;
            return DateTime.TryParse(values[parameterName].ToString(), out dateValue);
        }
    }
}
