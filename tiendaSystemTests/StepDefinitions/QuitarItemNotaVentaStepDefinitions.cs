using FluentAssertions;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using tiendaSystem.models;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class QuitarItemNotaVentaStepDefinitions
    {
        public NotaVenta notaVenta;

        [Given(@"Nota de venta con una lista de productos")]
        public void GivenNotaDeVentaConUnaListaDeProductos(Table table)
        {
            this.notaVenta = new NotaVenta();
            foreach(dynamic data in table.CreateDynamicSet())
            {
                Producto producto = new Producto(data.Id);
                producto.Stock = 20;
                this.notaVenta.agregarItem(new NotaVentaDetalle(producto, 10, 5));
            }
        }

        [When(@"Se quita el producto de id (.*)")]
        public void WhenSeQuitaElProductoDeId(int id)
        {
            this.notaVenta.quitarItem(id);
        }

        [Then(@"El producto de id (.*) ya no esta en la lista")]
        public void ThenElProductoYaNoEstaEnLaLista(int id)
        {
            this.notaVenta.NotaVentaDetalle.Find((detalle) => detalle.Producto.Id == id).Should().BeNull();
        }
    }
}
