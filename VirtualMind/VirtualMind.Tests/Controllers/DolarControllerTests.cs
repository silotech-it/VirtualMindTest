using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualMind.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMind.Controllers.Tests
{
    [TestClass()]
    public class DolarControllerTests
    {
        [TestMethod()]
        public void GetDolarTest()
        {
            VirtualMind.Controllers.DolarController dolar = new DolarController();
            var currencies = dolar.GetDolar();
            Assert.AreNotEqual(currencies.Count(), 0);
        }
    }
}