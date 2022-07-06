using System;
using TechTalk.SpecFlow;
using tiendaSystem.models;
using tiendaSystem.controllers;
using System.Data;
using FluentAssertions;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class AsignarProveedorANotaCompraStepDefinitions
    {
        //private DataTable proveedoresEncontrados;
        //private bool ok;

        //[Given(@"Un Numero de Ruc ""([^""]*)""")]
        //public void GivenUnNumeroDeRuc(string ruc)
        //{
        //    this.proveedoresEncontrados = new ProveedorController().getProveedoresPorRuc(ruc);
        //}

        //[When(@"Se quiere asignar a una Nota de Ingreso")]
        //public void WhenSeQuiereAsignarAUnaNotaDeIngreso()
        //{
        //    if(this.proveedoresEncontrados.Rows.Count > 0)
        //    {
        //        this.ok = true;
        //    }
        //    else
        //    {
        //        this.ok = false;
        //    }
        //}

        //[Then(@"Se informa que no existe registrado el Proveedor")]
        //public void ThenSeInformaQueNoExisteRegistradoElProveedor()
        //{
        //    this.ok.Should().Be(false);
        //}
    }
}
