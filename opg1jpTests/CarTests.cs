using Microsoft.VisualStudio.TestTools.UnitTesting;
using opg1jp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg1jp.Tests
{
    [TestClass()]

    public class CarTests
    {
        private Car _car;

        [TestInitialize()]
        public void ProTest()
        {
            _car = new Car(1, "Hyundai", 2000, "JP12321");
        }

        [TestMethod()]
        public void testModel()
        {
            Assert.AreEqual("Hyundai", _car.Model);
            Assert.ThrowsException<ArgumentNullException>(() => _car.Model = null);
            Assert.ThrowsException<ArgumentException>(() => _car.Model = "kia");
        }

        [TestMethod()]
        public void testPrice()
        {
            Assert.AreEqual(2000, _car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = -100);
        }

        [TestMethod()]
        public void testLicensePlate()
        {
            Assert.AreEqual("JP12321", _car.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.LicensePlate = "a1");
            Assert.ThrowsException<ArgumentNullException>(() => _car.LicensePlate = null);
        }


    }
}