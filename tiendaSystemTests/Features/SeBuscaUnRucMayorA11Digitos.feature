Feature: SeBuscaUnRucMayorA11Digitos

A short summary of the feature

@tag1
Scenario: SeBuscaUnRucMayorA11Digitos
	Given Queremos buscar un cliente
	When Se intenta buscar en la base de datos el ruc "205052435915"
	Then Deberia aparecer el mensaje "El ruc debe ser de 11 caracteres"
