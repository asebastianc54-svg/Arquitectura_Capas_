namespace Ejercicio3_Vehiculos.Negocio
{
    public class Vehiculo
    {
        public string Patente { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public bool TieneDeuda { get; set; }

        public Vehiculo(string patente, string modelo, bool tieneDeuda)
        {
            Patente = patente;
            Modelo = modelo;
            TieneDeuda = tieneDeuda;
        }
    }
}
