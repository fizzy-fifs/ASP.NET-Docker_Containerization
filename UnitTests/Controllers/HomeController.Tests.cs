using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace AppTests
{
    [TestClass]
    public class HomeControllerTests
    {
        private Mock<ILogger<HomeController>> _mockLogger;

        [TestInitialize]
        public void On_Class_Initialize()
        {
            _mockLogger = new Mock<ILogger<HomeController>>();
        }

        [TestMethod]
        public void Can_Render_Index()
        {
            var mock = new Mock<ILogger<HomeController>>();

            HomeController controller = new(_mockLogger.Object);

            ViewResult result = (ViewResult)controller.Index();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Can_Render_Privacy()
        {
            var mock = new Mock<ILogger<HomeController>>();

            HomeController controller = new(_mockLogger.Object);

            ViewResult result = controller.Privacy() as ViewResult;

            Assert.IsNotNull("Privacy", result.ViewName);
        }
    }
}
