using Ejercicio3_Vehiculos.Negocio;

namespace Ejercicio3_Vehiculos.Datos
{
    public class VehiculoDatos
    {
        private readonly List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Vehiculo("AA123CD", "Volkswagen Gol Trend", false),
            new Vehiculo("AE456FG", "Toyota Corolla", true),
            new Vehiculo("AB789HI", "Ford Fiesta Kinetic", false)
        };

        public Vehiculo? BuscarPorPatente(string patente)
        {
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Patente.Equals(patente, StringComparison.OrdinalIgnoreCase))
                {
                    return vehiculo;
                }
            }
            return null;
        }
    }
}
