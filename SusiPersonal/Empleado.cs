namespace Empleado.logica
{
    class Empleado
    {
        string nombre;
        string apellido;
        DateTime fecha_nacimiento;
        char estado_civil;
        double sueldo_basico;

        public Empleado(DateTime fecha)
        {
            this.fecha_nacimiento = fecha;
        }

    }   
}