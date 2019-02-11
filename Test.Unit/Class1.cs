using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using Think.Web.Controllers;

namespace Test.Unit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Should_Display()
        {
            var viewResult = (ViewResult)new AccountController().CheckLogin("yuan","123456");

           // Assert.AreEqual( viewResult.ViewData.Model);

            // Arrange
            //HomeController controller = new HomeController();

            //// Act
            //ViewResult result = controller.Index() as ViewResult;

            //// Assert
            //Assert.IsNotNull(result);
        }
        [Test]
        public void IsValidFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("filewithbadextension.PNG");
            Assert.AreEqual(false, result);
        }
    }
}
