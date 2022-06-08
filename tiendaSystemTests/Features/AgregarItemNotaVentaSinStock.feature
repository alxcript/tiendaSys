Feature: AgregarItemNotaVentaSinStock

Se intenta añadir un producto con stock insuficiente a la lista de venta

@tag1
Scenario: SeAgregaItemConStockInsuficiente
	Given Un producto con stock 10
	When Se quiere vender 11 unidades
	Then No se debe permitir