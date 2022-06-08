Feature: IdProductoNoExisteEnNotaVenta

A short summary of the feature

@tag1
Scenario: IdProductoNoExisteEnNotaVenta
	Given una lista de productos con ids
	| Id  |
	| 71  |
	| 72  |
	| 73  |
	When Se quiere quitar el id 99
	Then Se deberia de mostrar el mensaje "No existe el producto de id 99 en la lista"
