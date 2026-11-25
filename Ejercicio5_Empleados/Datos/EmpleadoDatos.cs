using Ejercicio5_Empleados.Negocio;

namespace Ejercicio5_Empleados.Datos
{
    public class EmpleadoDatos
    {
        private readonly List<Empleado> empleados = new List<Empleado>
        {
            new Empleado(501, "Diego Ibáñez", "Desarrollador Backend", "Sistemas"),
            new Empleado(502, "Carolina Muñoz", "Analista de Selección", "Recursos Humanos"),
            new Empleado(503, "Hernán Castañeda", "Administrador de Redes", "Infraestructura")
        };

        public Empleado? BuscarPorId(int id)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Id == id)
                {
                    return empleado;
                }
            }
            return null;
        }
    }
}
