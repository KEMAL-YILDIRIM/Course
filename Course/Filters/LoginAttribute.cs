using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Course.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext
    filterContext)
        {
            // Login icin filtre mantigi buraya yazilacak

            if (HttpContext.Current.Session == null)
            {

                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary{{ "controller", "Login" },
                                          { "action", "Index" }

                                     });
            }else if (HttpContext.Current.Session["role"] == null)
            {

                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary{
                        { "controller", "User" },
                        { "action", "Index" }

                                     });
            }
            base.OnActionExecuting(filterContext);
        }
    }
}