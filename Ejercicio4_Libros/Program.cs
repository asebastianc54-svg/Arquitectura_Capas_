using Ejercicio4_Libros.Negocio;

LibroNegocio negocio = new LibroNegocio();

Console.Write("Ingrese el codigo ISBN del libro (ej: 978-84-376-0494-7): ");
string? isbn = Console.ReadLine();

try
{
    Libro libro = negocio.ConsultarLibro(isbn);
    string estado = libro.Disponible ? "Disponible" : "Prestado";
    Console.WriteLine($"Titulo: {libro.Titulo} | Autor: {libro.Autor} | Estado: {estado}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
