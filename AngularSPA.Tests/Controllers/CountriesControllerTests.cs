using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using AngularSPA.Services;
using AngularSPA.Entities;
using AngularSPA.Controllers;

namespace AngularSPA.Tests.Controllers
{
    [TestClass]
    public class CountriesControllerTests
    {
       [TestMethod]
       public void GetTest_Normal()
        {
            var countryService = new Mock<ICountryService>();
            countryService.Setup(p => p.Get(1)).Returns(CreateCountry());

            var countryController = new CountriesController(countryService.Object);
            var result = countryController.Get(1);

            Assert.AreEqual(result.CountryCode, "0061");
        }


        private Country CreateCountry()
        {
            return new Country
            {
                CountryCode = "0061",
                CountryName = "Australia",
                IsActive = true,
                Comments = null,
                CreatedTime = DateTime.UtcNow
            };
        }
    }
}
