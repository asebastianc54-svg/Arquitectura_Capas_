namespace Ejercicio5_Empleados.Negocio
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Puesto { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;

        public Empleado(int id, string nombre, string puesto, string departamento)
        {
            Id = id;
            Nombre = nombre;
            Puesto = puesto;
            Departamento = departamento;
        }
    }
}
