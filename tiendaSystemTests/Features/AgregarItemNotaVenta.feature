Feature: AgregarItemNotaVenta

A short summary of the feature

@tag1
Scenario: ElProductoNoExiste
	Given Se quiere agregar un producto a una nota de venta
	When Se busca un producto de Id 9999
	Then Se deberia mostrar el mensaje "No existe el producto con el id 9999"
