using System.Security.Cryptography;

namespace LogicaEmpleado
{
    public class Empleado
    {
        public Empleado(string apellido, string nombre, DateTime fecha_n, DateTime fecha_ingreso)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.FechaNacimiento = fecha_n;
            this.FechaIngresoEmpresa = fecha_ingreso;
        }
        public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private DateTime FechaNacimiento { get; }
        private DateTime FechaIngresoEmpresa { get; }

        public DateTime GetFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public DateTime GetFechaIngresoEmpresa()
        {
            return FechaIngresoEmpresa;
        }
        public double SueldoBasico { get; set; }
        public char EstadoCivil { get; set; }
        public Cargos Cargo { get; set; }

        public int calculo_tiempo(DateTime fecha_inicio)
        {
            return DateTime.Now.Year - fecha_inicio.Year;
        }
        public int jubilacion(DateTime fecha_inicio)
        {
            int edad = calculo_tiempo(fecha_inicio);
            if (edad <= 65)
                 return  65 - edad;
            return 0;
        }
        public double adicional(DateTime fecha_inicio, double sueldo_basico)
        {
            double adicional = 0;

            //Calculos por años de antiguedad
            if (jubilacion(fecha_inicio) <= 20)
                adicional = sueldo_basico + 0.2 * sueldo_basico;
            else
                adicional = sueldo_basico + 0.25 * sueldo_basico;

            //Calculos por especialidad
            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                adicional += sueldo_basico + 0.5;

            //Calculos por estado civil
            if (EstadoCivil == 'C')
                adicional += 150000;

            return adicional;
        }
        public double calcular_salario(double sueldo_basico, double adicional)
        {
            return sueldo_basico + adicional;
        }
    }   
}