using Ejercicio4_Libros.Datos;

namespace Ejercicio4_Libros.Negocio
{
    public class LibroNegocio
    {
        private readonly LibroDatos datos = new LibroDatos();

        public Libro ConsultarLibro(string? isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
            {
                throw new ArgumentException("El código ISBN no puede ser nulo ni estar vacío.");
            }

            Libro? libro = datos.BuscarPorIsbn(isbn.Trim());
            if (libro == null)
            {
                throw new KeyNotFoundException("No se encontró ningún libro con el ISBN ingresado.");
            }

            return libro;
        }
    }
}
