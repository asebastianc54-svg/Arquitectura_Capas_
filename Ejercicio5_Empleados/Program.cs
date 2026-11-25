using Ejercicio5_Empleados.Negocio;

EmpleadoNegocio negocio = new EmpleadoNegocio();

Console.Write("Ingrese el ID de Empleado (ej: 501): ");
string? entrada = Console.ReadLine();

if (int.TryParse(entrada, out int id))
{
    try
    {
        Empleado empleado = negocio.ConsultarEmpleado(id);
        Console.WriteLine($"Nombre: {empleado.Nombre} | Puesto: {empleado.Puesto} | Departamento: {empleado.Departamento}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
else
{
    Console.WriteLine("Error: Debe ingresar un numero entero valido para el ID.");
}
