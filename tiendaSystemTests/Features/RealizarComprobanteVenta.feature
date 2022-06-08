Feature: RealizarComprobanteVenta

Como usuarioDeVentas
Quiero realizar una boleta de venta
Para registrar las ventas a los clientes.

Scenario: AgregarItemANotaDeVenta
	Given Seleccionado un producto de precio de venta 10.00 con stock 200
	And Se coloca 5 en la cantidad
	When Agrega a una lista vacia
	Then El precio de Venta Total es de 50
