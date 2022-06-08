using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using tiendaSystem.models;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class RealizarComprobanteVentaStepDefinitions
    {
        private NotaVenta notaVenta;
        private Producto producto;
        private NotaVentaDetalle notaVentaDetalle;

        [Given(@"Seleccionado un producto de precio de venta (.*) con stock (.*)")]
        public void GivenSeleccionadoUnProductoDePrecioDeVentaConStock(double precioVenta, int stock)
        {
            this.notaVenta = new NotaVenta();
            this.producto = new Producto(1, "Jacuzzi Glass Fibber 2.40 x 1.2 Deluxe", "Jax", 0, precioVenta, "UND", "TINA", 0);
            this.producto.Stock = stock;
        }

        [Given(@"Se coloca (.*) en la cantidad")]
        public void GivenSeColocaEnLaCantidad(int cantidad)
        {
            this.notaVentaDetalle = new NotaVentaDetalle(this.producto, cantidad, this.producto.PrecioVenta);
        }

        [When(@"Agrega a una lista vacia")]
        public void WhenAgregaAUnaListaVacia()
        {
            this.notaVenta.agregarItem(this.notaVentaDetalle);
        }

        [Then(@"El precio de Venta Total es de (.*)")]
        public void ThenElPrecioDeVentaTotalEsDe(int precioVentaTotal)
        {
            Assert.AreEqual(this.notaVenta.Total, precioVentaTotal);
        }
    }
}
