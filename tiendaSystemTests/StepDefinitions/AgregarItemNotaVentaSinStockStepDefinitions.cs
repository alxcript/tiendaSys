using FluentAssertions;
using System;
using TechTalk.SpecFlow;
using tiendaSystem.models;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class AgregarItemNotaVentaSinStockStepDefinitions
    {
        private Producto producto;
        private NotaVenta notaVenta;
        private bool ok;

        [Given(@"Un producto con stock (.*)")]
        public void GivenUnProductoConStock(int stock)
        {
            this.producto = new Producto();
            this.producto.Stock = stock;
        }

        [When(@"Se quiere vender (.*) unidades")]
        public void WhenSeQuiereVenderUnidades(int cantidad)
        {
            this.notaVenta = new NotaVenta();
            ok = this.notaVenta.agregarItem(new NotaVentaDetalle(this.producto, cantidad, this.producto.PrecioVenta));
        }

        [Then(@"No se debe permitir")]
        public void ThenNoSeDebePermitir()
        {
            this.ok.Should().Be(false);
        }
    }
}
