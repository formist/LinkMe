﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="LinkMe.Framework.Utility.Urls"%>
<%@ Import Namespace="LinkMe.Apps.Asp.Mvc.Views"%>
<%@ Import Namespace="LinkMe.Web.Content"%>

<%= Html.StyleSheet(StyleSheets.Communities) %>
<link href="<%= new ReadOnlyApplicationUrl("~/themes/communities/otd/css/otd.css") %>" rel="stylesheet" />
