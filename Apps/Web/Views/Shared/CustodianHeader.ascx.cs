﻿using LinkMe.Apps.Asp.Mvc.Views;
using LinkMe.Apps.Asp.Routing;
using LinkMe.Framework.Utility.Urls;
using LinkMe.Web.Areas.Public.Routes;

namespace LinkMe.Web.Views.Shared
{
    public class CustodianHeader
        : ViewUserControl
    {
        protected static ReadOnlyUrl HomeUrl { get { return Areas.Custodians.Routes.HomeRoutes.Home.GenerateUrl(); } }
        protected static ReadOnlyUrl LogOutUrl { get { return LoginsRoutes.LogOut.GenerateUrl(); } }
    }
}