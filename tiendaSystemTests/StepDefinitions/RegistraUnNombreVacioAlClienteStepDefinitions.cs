using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using tiendaSystem.models;

namespace tiendaSystemTests.StepDefinitions
{
    [Binding]
    public class RegistraUnNombreVacioAlClienteStepDefinitions
    {
        private Cliente cliente;
        private ArgumentException argumentException;
        private string nombreVacio;

        [Given(@"Un nombre de cliente sin caracteres")]
        public void GivenUnNombreDeClienteSinCaracteres()
        {
            this.nombreVacio = "";
        }

        [When(@"Se registra en el nombre del cliente")]
        public void WhenSeRegistraEnElNombreDelCliente()
        {
            this.cliente = new Cliente();
            try
            {
                this.cliente.Nombre = this.nombreVacio;
            }
            catch (ArgumentException ex)
            {
                this.argumentException = ex;
            }
        }

        [Then(@"Deberia aparecer el error ""([^""]*)""")]
        public void ThenDeberiaAparecerElError(string mensajeError)
        {
            StringAssert.Contains(mensajeError, this.argumentException.Message);
        }

    }
}
