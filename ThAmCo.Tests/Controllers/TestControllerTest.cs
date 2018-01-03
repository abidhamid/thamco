using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThAmCo;
using ThAmCo.Controllers;

namespace ThAmCo.Tests.Controllers
{
    [TestClass]
    public class TestControllerTest
    {


        [TestMethod]
        public void Test1()
        {
            // Arrange
            TestController controller = new TestController();

            // Act
            ContentResult result = controller.Test1() as ContentResult;

            // Assert
            Assert.IsNotNull(result);
        }



    }
}
