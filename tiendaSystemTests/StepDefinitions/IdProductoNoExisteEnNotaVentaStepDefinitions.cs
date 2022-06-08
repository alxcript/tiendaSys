using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using tiendaSystem.controllers;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class IdProductoNoExisteEnNotaVentaStepDefinitions
    {
        private NotaVentaController notaVentaController;
        private KeyNotFoundException keyNotFoundException;

        [Given(@"una lista de productos con ids")]
        public void GivenUnaListaDeProductosConIds(Table table)
        {
            this.notaVentaController = new NotaVentaController();
            foreach(dynamic data in table.CreateDynamicSet())
            {
                this.notaVentaController.agregarItemNuevaVenta(data.Id, 5);
            }
        }

        [When(@"Se quiere quitar el id (.*)")]
        public void WhenSeQuiereQuitarElId(int id)
        {
            try
            {
                this.notaVentaController.quitarItemNuevaVenta(id);
            }
            catch (KeyNotFoundException ex)
            {
                this.keyNotFoundException = ex;
            }
        }

        [Then(@"Se deberia de mostrar el mensaje ""([^""]*)""")]
        public void ThenSeDeberiaDeMostrarElMensaje(string mensaje)
        {
            StringAssert.Contains(mensaje, this.keyNotFoundException.Message);
        }

    }
}
