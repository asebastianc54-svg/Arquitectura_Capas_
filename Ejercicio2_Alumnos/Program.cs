using Ejercicio2_Alumnos.Negocio;

AlumnoNegocio negocio = new AlumnoNegocio();

Console.Write("Ingrese el numero de Legajo (ej: 10042): ");
string? entrada = Console.ReadLine();

if (int.TryParse(entrada, out int legajo))
{
    string resultado = negocio.ConsultarEstadoAcademico(legajo);
    Console.WriteLine(resultado);
}
else
{
    Console.WriteLine("Error: Debe ingresar un numero entero valido para el legajo.");
}
