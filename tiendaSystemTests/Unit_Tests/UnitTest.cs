using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiendaSystem.models;

namespace tiendaSystemTests.Unit_Tests
{
    public class UnitTest
    {
        private const string Expected = "Hello World!";
        private Proveedor proveedor = new Proveedor(1, "20532050268", "Consorcio Arenas", "Las Begonias # 1352");
        private Proveedor proveedorIncorrecto = new Proveedor();

        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(Expected, "Hello World!");
        }

        [Test]
        public void getProveedorId()
        {
            Assert.AreEqual(1, this.proveedor.Id);
        }

        [Test]
        public void rucShouldBeElevenCharacters()
        {
            Assert.AreEqual(11, this.proveedor.Ruc.Length);
        }

        [Test]
        public void rucShouldNotBeMoreThanElevenCharacters()
        {
            Assert.Throws(
                Is.TypeOf<ArgumentOutOfRangeException>()
                .And.Message.Contains("El ruc debe tener 11 caracteres"),
                () => this.proveedorIncorrecto.Ruc = "123456789102");
        }

        [Test]
        public void razonSocialNotShouldBeEmptyOrNull()
        {
            Assert.Throws(
                Is.TypeOf<ArgumentException>()
                .And.Message.Contains("La Razon Social no puede ser vacía"),
                () => this.proveedorIncorrecto.RazonSocial = "");
        }
    }
}
