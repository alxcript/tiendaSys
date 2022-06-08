Feature: RegistraUnNombreVacioAlCliente

A short summary of the feature

@tag1
Scenario: RegistraUnNombreVacioAlCliente
	Given Un nombre de cliente sin caracteres
	When Se registra en el nombre del cliente
	Then Deberia aparecer el error "El nombre ingresado es inválido"
