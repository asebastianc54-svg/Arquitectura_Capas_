using Ejercicio2_Alumnos.Datos;

namespace Ejercicio2_Alumnos.Negocio
{
    public class AlumnoNegocio
    {
        private readonly AlumnoDatos datos = new AlumnoDatos();

        public string ConsultarEstadoAcademico(int legajo)
        {
            if (legajo <= 0)
            {
                return "Error: El número de legajo debe ser mayor a cero.";
            }

            Alumno? alumno = datos.BuscarPorLegajo(legajo);
            if (alumno == null)
            {
                return "Error: No existe un alumno registrado con ese legajo.";
            }

            return $"Alumno: {alumno.Nombre} | Condición: {alumno.Condicion}";
        }
    }
}
