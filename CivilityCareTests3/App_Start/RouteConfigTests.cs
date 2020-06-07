using Microsoft.VisualStudio.TestTools.UnitTesting;
using CivilityCare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Web;
using System.Web.Routing;

namespace CivilityCare.Tests
{
    [TestClass()]
    public class RouteConfigTests
    {
        [TestMethod()]
        public void RegisterRoutesTest()
        {
            var mockHttpContext = new Mock<HttpContextBase>();
            mockHttpContext.Setup(h => h.Request.AppRelativeCurrentExecutionFilePath).Returns("~/");

            var routeCollection = new RouteCollection();
            RouteConfig.RegisterRoutes(routeCollection);

            var routeData = routeCollection.GetRouteData(mockHttpContext.Object);

            Assert.IsNotNull(routeData);
            Assert.AreEqual("Home", routeData.Values["controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);

            
        }
    }
}