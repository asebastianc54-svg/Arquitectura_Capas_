using Ejercicio4_Libros.Negocio;

namespace Ejercicio4_Libros.Datos
{
    public class LibroDatos
    {
        private readonly List<Libro> libros = new List<Libro>
        {
            new Libro("978-84-376-0494-7", "Cien años de soledad", "Gabriel García Márquez", true),
            new Libro("978-950-07-0010-8", "El Aleph", "Jorge Luis Borges", false),
            new Libro("978-84-204-7183-9", "Don Quijote de la Mancha", "Miguel de Cervantes", true)
        };

        public Libro? BuscarPorIsbn(string isbn)
        {
            foreach (Libro libro in libros)
            {
                if (libro.Isbn.Equals(isbn, StringComparison.OrdinalIgnoreCase))
                {
                    return libro;
                }
            }
            return null;
        }
    }
}
