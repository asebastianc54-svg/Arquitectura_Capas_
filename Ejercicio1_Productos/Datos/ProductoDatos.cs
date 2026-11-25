using Ejercicio1_Productos.Negocio;

namespace Ejercicio1_Productos.Datos
{
    public class ProductoDatos
    {
        private readonly List<Producto> productos = new List<Producto>
        {
            new Producto("PROD-101", "Teclado Mecánico Español", 45500m),
            new Producto("PROD-102", "Mouse Inalámbrico", 22000m),
            new Producto("PROD-103", "Monitor 27 Pulgadas", 280000m)
        };

        public Producto? BuscarPorCodigo(string codigo)
        {
            foreach (Producto producto in productos)
            {
                if (producto.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase))
                {
                    return producto;
                }
            }
            return null;
        }
    }
}
