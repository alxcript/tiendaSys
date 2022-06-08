using System;
using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using tiendaSystem.controllers;
using tiendaSystem.models;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class CrearNuevoProductoStepDefinitions
    {
        private Producto producto;
        private int newId;
        private ProductosController productoController;


        [Given(@"Un producto con los datos")]
        public void GivenUnProductoConLosDatos(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            this.productoController = new ProductosController();
            this.newId = this.productoController.getIdProductoNuevo();
            this.producto = new Producto(newId, (string)data.Descripcion, (string)data.Marca, (double)data.CostoCompra, (double)data.PrecioVenta, (string)data.UnidadMedida, (string)data.Categoria, (double)data.PrecioVentaMinimo);
        }

        [When(@"Guarda el producto")]
        public void WhenGuardaElProducto()
        {
            this.productoController.grabarProductoEnBD(this.producto);
        }

        [Then(@"Existe en el catalogo")]
        public void ThenExisteEnElCatalogo()
        {
            this.productoController.getProductosPorDescripcion(this.producto.Descripcion).Count.Should().BeGreaterThanOrEqualTo(1);
        }
    }
}
