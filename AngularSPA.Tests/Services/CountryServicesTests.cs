using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using AngularSPA.Entities;

namespace AngularSPA.Tests.Services
{
    [TestClass]
    public class CountryServicesTests
    {

        [TestInitialize]
        public void Initialize()
        {
        }


        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void GetAll_Normal()
        {
            throw new NotImplementedException();
        }



        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Get_Normal()
        {
            throw new ArgumentOutOfRangeException();
        }

    }
}
