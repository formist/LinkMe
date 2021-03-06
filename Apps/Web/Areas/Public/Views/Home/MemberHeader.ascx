﻿<%@ Control Language="C#" Inherits="LinkMe.Web.Views.Shared.MemberHeader" %>
<%@ Import Namespace="LinkMe.Web.Areas.Public.Models.Home"%>
<%@ Import Namespace="LinkMe.Apps.Agents.Security"%>
<%@ Import Namespace="LinkMe.Framework.Utility"%>

<div id="header-links-container">
    <script type="text/javascript">
        function loadPage(url) {
            window.location = url;
        }
    </script>
    <div id="header-links">
        <div class="left-section">
<%  if (CurrentMember != null)
    { %>
            <div id="logo" onclick="javascript:loadPage('<%= HomeUrl %>');"></div>
<%  }
    else
    { %>
            <div id="logo" onclick="javascript:loadPage('<%= AnonymousHomeUrl %>');"></div>
<%  } %>
            <% Html.RenderPartial("MemberNav"); %>
        </div>
        <div class="right-section">
            <div id="action-links">
                <div class="rhs-links">
<%  if (CurrentMember != null)
    { %>
                    <div class="user-name_holder">Logged in as <div class="user-name"><%= TextUtil.TruncateForDisplay(Context.User.FullName(), 20)%></div></div>                        
                    <div class="logout action-link" onclick="javascript:loadPage('<%= LogOutUrl %>');"></div>
                    <div class="settings action-link" onclick="javascript:loadPage('<%= AccountUrl %>');"></div>
<%  }
    else
    { %>
                    <div class="employer switch-link" onclick="javascript:loadPage('<%= EmployerHomeUrl %>');"></div>
<%  } %>
                </div>
            </div>
        </div>
    </div>
</div>
<div id="header-links-container-shadow"></div>

