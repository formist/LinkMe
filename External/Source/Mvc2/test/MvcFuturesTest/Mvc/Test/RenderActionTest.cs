﻿namespace Microsoft.Web.Mvc.Test {
    using System;
    using System.IO;
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.TestUtil;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Web.Mvc;
    using Microsoft.Web.UnitTestUtil;
    using Moq;

    [TestClass]
    public class RenderActionTest {

        [TestMethod]
        public void RenderActionUsingExpressionWithParametersInViewContextRendersCorrectly() {
            // Arrange
            Func<RequestContext> requestContextAccessor;
            HtmlHelper html = GetHtmlHelper(out requestContextAccessor);
            html.ViewContext.RouteData.Values.Add("stuff", "42");

            // Act
            html.RenderAction<TestController>(c => c.Stuff());
            RequestContext requestContext = requestContextAccessor();

            // Assert
            Assert.IsNotNull(requestContext);
            Assert.AreEqual("Test", requestContext.RouteData.Values["controller"]);
            Assert.AreEqual("Stuff", requestContext.RouteData.Values["action"]);
            Assert.AreEqual("42", requestContext.RouteData.Values["stuff"]);
        }

        [TestMethod]
        public void RenderActionUsingExpressionRendersCorrectly() {
            // Arrange
            Func<RequestContext> requestContextAccessor;
            HtmlHelper html = GetHtmlHelper(out requestContextAccessor);

            // Act
            html.RenderAction<TestController>(c => c.About(76));
            RequestContext requestContext = requestContextAccessor();

            // Assert
            Assert.IsNotNull(requestContext);
            Assert.AreEqual("Test", requestContext.RouteData.Values["controller"]);
            Assert.AreEqual("About", requestContext.RouteData.Values["action"]);
            Assert.AreEqual(76, requestContext.RouteData.Values["page"]);
        }

        [TestMethod]
        public void RenderRouteWithNullRouteValueDictionaryThrowsException() {
            HtmlHelper html = MvcHelper.GetHtmlHelperWithPath(new ViewDataDictionary(), "/");
            ExceptionHelper.ExpectArgumentNullException(() => html.RenderRoute(null), "routeValues");
        }

        [TestMethod]
        public void RenderRouteWithActionAndControllerSpecifiedRendersCorrectAction() {
            // Arrange
            Func<RequestContext> requestContextAccessor;
            HtmlHelper html = GetHtmlHelper(out requestContextAccessor);

            // Act
            html.RenderRoute(new RouteValueDictionary(new { action = "Index", controller = "Test" }));
            RequestContext requestContext = requestContextAccessor();

            // Assert
            Assert.IsNotNull(requestContext);
            Assert.AreEqual("Test", requestContext.RouteData.Values["controller"]);
            Assert.AreEqual("Index", requestContext.RouteData.Values["action"]);
        }

        private static HtmlHelper GetHtmlHelper(out Func<RequestContext> requestContextAccessor) {
            RequestContext requestContext = null;

            HtmlHelper html = MvcHelper.GetHtmlHelperWithPath(new ViewDataDictionary(), "/");

            html.RouteCollection.MapRoute(null, "{*dummy}");
            Mock.Get(html.ViewContext.HttpContext)
                .Expect(o => o.Server.Execute(It.IsAny<IHttpHandler>(), It.IsAny<TextWriter>(), It.IsAny<bool>()))
                .Callback<IHttpHandler, TextWriter, bool>((_h, _w, _pf) => {
                    MvcHandler mvcHandler = _h.GetType().GetProperty("InnerHandler", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_h, null) as MvcHandler;
                    requestContext = mvcHandler.RequestContext;
                });

            requestContextAccessor = () => requestContext;
            return html;
        }

        public class TestController : Controller {
            public string Index() {
                return "It Worked!";
            }

            public string About(int page) {
                return "This is page #" + page;
            }

            public string Stuff() {
                string stuff = ControllerContext.RouteData.Values["stuff"] as string;
                return "Argument was " + stuff;
            }
        }

    }
}
