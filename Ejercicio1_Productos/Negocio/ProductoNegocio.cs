using Ejercicio1_Productos.Datos;

namespace Ejercicio1_Productos.Negocio
{
    public class ProductoNegocio
    {
        private readonly ProductoDatos datos = new ProductoDatos();

        public Producto ConsultarProducto(string? codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new ArgumentException("El código del producto no puede estar vacío.");
            }

            string codigoLimpio = codigo.Trim();
            if (!codigoLimpio.StartsWith("PROD-", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("El código debe comenzar obligatoriamente con el prefijo PROD-.");
            }

            Producto? encontrado = datos.BuscarPorCodigo(codigoLimpio);
            if (encontrado == null)
            {
                throw new KeyNotFoundException("No se encontró ningún producto con ese código.");
            }

            return encontrado;
        }
    }
}
