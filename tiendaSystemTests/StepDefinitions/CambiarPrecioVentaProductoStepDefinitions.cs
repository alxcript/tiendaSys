using FluentAssertions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using tiendaSystem.models;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class CambiarPrecioVentaProductoStepDefinitions
    {
        private NotaVenta notaVenta;

        [Given(@"Un lista de Venta de productos")]
        public void GivenUnListaDeVentaDeProductos(Table table)
        {
            this.notaVenta = new NotaVenta();
            foreach(dynamic data in table.CreateDynamicSet())
            {
                Producto producto = new Producto(data.Id);
                producto.Stock = 100;
                producto.PrecioVenta = data.PrecioVenta;
                this.notaVenta.agregarItem(new NotaVentaDetalle(producto, data.Cantidad, data.PrecioVenta));
            }
        }

        [When(@"Cambio la el precio de Venta del producto de id (.*) a (.*)")]
        public void WhenCambioLaElPrecioDeVentaDelProductoDeIdA(int id, double nuevoPrecioVenta)
        {
            this.notaVenta.cambiarPrecioVentaUnitario(id, nuevoPrecioVenta);
        }

        [Then(@"El nuevo precio total de Venta es (.*)")]
        public void ThenElNuevoPrecioTotalDeVentaEs(double precioTotal)
        {
            Assert.AreEqual(precioTotal, this.notaVenta.Total);
        }
    }
}
