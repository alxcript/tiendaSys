Feature: CambiarPrecioVentaProducto

A short summary of the feature

@tag1
Scenario: CambiarPrecioVentaProductoDeNotaVenta
	Given Un lista de Venta de productos
	| Id  | Cantidad | PrecioVenta |
	| 12  | 4.0        | 10.00       |
	| 45  | 2.0        | 6.00        |
	| 155 | 1.0        | 85.00       |
	When Cambio la el precio de Venta del producto de id 45 a 5
	Then El nuevo precio total de Venta es 135.00
