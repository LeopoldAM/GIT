using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternBusinessTests;

namespace DesignPatternBusiness.Tests
{
    [TestClass()]
    public class BusinessEmployeTests
    {
        [TestMethod()]
        public void GetSommeSalaireTest()
        {
            // AAA

            // Arrange
            var entrepriseService = new BusinessEmploye(new MockStorage());

            // Act
            var salaire = entrepriseService.GetSommeSalaire();

            // Assert
            Assert.AreEqual(salaire, 10);
        }
    }
}