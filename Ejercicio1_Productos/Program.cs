using Ejercicio1_Productos.Negocio;

ProductoNegocio negocio = new ProductoNegocio();

Console.Write("Ingrese el Codigo del Producto (ej: PROD-101): ");
string? codigo = Console.ReadLine();

try
{
    Producto producto = negocio.ConsultarProducto(codigo);
    Console.WriteLine($"Producto encontrado: {producto.Nombre} | Precio: ${producto.Precio:F2}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
