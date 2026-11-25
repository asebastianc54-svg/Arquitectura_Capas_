using Ejercicio5_Empleados.Datos;

namespace Ejercicio5_Empleados.Negocio
{
    public class EmpleadoNegocio
    {
        private readonly EmpleadoDatos datos = new EmpleadoDatos();

        public Empleado ConsultarEmpleado(int id)
        {
            if (id < 100 || id > 999)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "El ID de empleado debe estar entre 100 y 999.");
            }

            Empleado? empleado = datos.BuscarPorId(id);
            if (empleado == null)
            {
                throw new KeyNotFoundException("No se encontró ningún empleado registrado con ese ID.");
            }

            return empleado;
        }
    }
}
