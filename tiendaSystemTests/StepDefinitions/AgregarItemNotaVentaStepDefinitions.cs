using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using tiendaSystem.controllers;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class AgregarItemNotaVentaStepDefinitions
    {
        private NotaVentaController notaVentaController;
        private KeyNotFoundException keyNotFoundException;

        [Given(@"Se quiere agregar un producto a una nota de venta")]
        public void GivenSeQuiereAgregarUnProductoAUnaNotaDeVenta()
        {
            this.notaVentaController = new NotaVentaController();
        }

        [When(@"Se busca un producto de Id (.*)")]
        public void WhenSeBuscaUnProductoDeId(int id)
        {
            try
            {
                this.notaVentaController.agregarItemNuevaVenta(id, 10);
            }
            catch (KeyNotFoundException ex)
            {
                this.keyNotFoundException = ex;
            }
            
        }

        [Then(@"Se deberia mostrar el mensaje ""([^""]*)""")]
        public void ThenSeDeberiaMostrarElMensaje(string mensaje)
        {
            StringAssert.Contains(mensaje, this.keyNotFoundException.Message);
        }
    }
}
