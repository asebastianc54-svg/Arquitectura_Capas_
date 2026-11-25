using Ejercicio2_Alumnos.Negocio;

namespace Ejercicio2_Alumnos.Datos
{
    public class AlumnoDatos
    {
        private readonly List<Alumno> alumnos = new List<Alumno>
        {
            new Alumno(10042, "Sebastián Canazas", "Aprobado"),
            new Alumno(10043, "Martín Peña", "Regular"),
            new Alumno(10044, "Lucía Núñez", "Promocionado")
        };

        public Alumno? BuscarPorLegajo(int legajo)
        {
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Legajo == legajo)
                {
                    return alumno;
                }
            }
            return null;
        }
    }
}
