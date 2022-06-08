Feature: AsignarProveedorANotaCompra

A short summary of the feature


Scenario: RucDelProveedorNoEstaRegistrado
	Given Un Numero de Ruc "12345678912"
	When Se quiere asignar a una Nota de Ingreso
	Then Se informa que no existe registrado el Proveedor
