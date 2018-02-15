using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternController.Tests
{
    [TestClass()]
    public class EmployeControllerTests
    {
        [TestMethod()]
        public void GetSommeSalaireTest()
        {
            var entrepriseService = new EntrepriseService(new MockStorage());
            var salaire = entrepriseService.GetSommeSalaire();
            Assert.AreEqual(salaire, 50);
        }
    }
}