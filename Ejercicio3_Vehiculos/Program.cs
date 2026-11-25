using Ejercicio3_Vehiculos.Negocio;

VehiculoNegocio negocio = new VehiculoNegocio();

Console.Write("Ingrese la Patente del vehiculo (ej: AA123CD): ");
string? patente = Console.ReadLine();

try
{
    Vehiculo vehiculo = negocio.ConsultarVehiculo(patente);
    string estadoDeuda = vehiculo.TieneDeuda ? "Posee deudas pendientes" : "Sin deudas pendientes";
    Console.WriteLine($"Modelo: {vehiculo.Modelo} | Estado: {estadoDeuda}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
