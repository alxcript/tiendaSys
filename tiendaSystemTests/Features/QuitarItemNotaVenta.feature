Feature: QuitarItemNotaVenta

Se quiere quitar un item de la nota venta

@tag1
Scenario: QuitarItemNotaVenta
	Given Nota de venta con una lista de productos
	| Id  |
	| 55  |
	| 42  |
	| 48  |
	| 105 |
	When Se quita el producto de id 48
	Then El producto de id 48 ya no esta en la lista
