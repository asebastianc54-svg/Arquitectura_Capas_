namespace Ejercicio2_Alumnos.Negocio
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Condicion { get; set; } = string.Empty;

        public Alumno(int legajo, string nombre, string condicion)
        {
            Legajo = legajo;
            Nombre = nombre;
            Condicion = condicion;
        }
    }
}
