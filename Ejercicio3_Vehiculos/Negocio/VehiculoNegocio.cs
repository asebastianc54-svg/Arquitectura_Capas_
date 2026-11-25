using Ejercicio3_Vehiculos.Datos;

namespace Ejercicio3_Vehiculos.Negocio
{
    public class VehiculoNegocio
    {
        private readonly VehiculoDatos datos = new VehiculoDatos();

        public Vehiculo ConsultarVehiculo(string? patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
            {
                throw new ArgumentException("La patente no puede estar vacía.");
            }

            string patenteLimpia = patente.Trim();
            if (patenteLimpia.Length < 6)
            {
                throw new ArgumentException("La patente debe tener al menos 6 caracteres.");
            }

            Vehiculo? vehiculo = datos.BuscarPorPatente(patenteLimpia);
            if (vehiculo == null)
            {
                throw new KeyNotFoundException("No se encontró ningún vehículo con esa patente.");
            }

            return vehiculo;
        }
    }
}
