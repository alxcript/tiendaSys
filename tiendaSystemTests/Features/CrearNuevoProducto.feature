Feature: CrearNuevoProducto

Se quiere agregar un nuevo producto al catalogo

@tag1
Scenario: CrearNuevoProductoEnlaBD
	Given Un producto con los datos
	| Descripcion                            | Marca | CostoCompra | PrecioVenta | UnidadMedida | Categoria | PrecioVentaMinimo |
	| Jacuzzi Glass Fibber 2.40 x 1.2 Deluxe | Jax   | 0           | 0           | UND          | TINA      | 0                 |
	When Guarda el producto
	Then Existe en el catalogo
