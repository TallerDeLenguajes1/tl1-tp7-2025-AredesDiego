using System;
using LogicaEmpleado;

internal class Program
{
    private static void Main(string[] args)
    {
        double total_salarios = 0;
        Empleado[] arreglo = new Empleado[3];

        arreglo[0] = new Empleado("Gonzalez", "Laura", new DateTime(1980, 5, 20), new DateTime(2005, 6, 1));
        arreglo[0].SueldoBasico = 300000;
        arreglo[0].EstadoCivil = 'C';
        arreglo[0].Cargo = Empleado.Cargos.Ingeniero;

        arreglo[1] = new Empleado("Martinez", "Carlos", new DateTime(1975, 3, 10), new DateTime(2010, 4, 15));
        arreglo[1].SueldoBasico = 280000;
        arreglo[1].EstadoCivil = 'S';
        arreglo[1].Cargo = Empleado.Cargos.Administrativo;

        arreglo[2] = new Empleado("Lopez", "Ana", new DateTime(1990, 7, 12), new DateTime(2018, 1, 5));
        arreglo[2].SueldoBasico = 250000;
        arreglo[2].EstadoCivil = 'C';
        arreglo[2].Cargo = Empleado.Cargos.Especialista;

        // Buscar el empleado más próximo a jubilarse
        int indiceMin = 0;
        int minAniosJubilacion = arreglo[0].jubilacion(arreglo[0].GetFechaNacimiento());

        for (int i = 1; i < arreglo.Length; i++)
        {
            int anios = arreglo[i].jubilacion(arreglo[i].GetFechaNacimiento());
            if (anios < minAniosJubilacion)
            {
                minAniosJubilacion = anios;
                indiceMin = i;
            }
        }

        // Mostrar solo ese empleado
        Empleado emp = arreglo[indiceMin];
        double adicional = emp.adicional(emp.GetFechaIngresoEmpresa(), emp.SueldoBasico);
        double salarioFinal = emp.calcular_salario(emp.SueldoBasico, adicional);
        total_salarios += salarioFinal;

        Console.WriteLine("Empleado más próximo a su jubilación:");
        Console.WriteLine($"Nombre: {emp.Nombre} {emp.Apellido}");
        Console.WriteLine($"Cargo: {emp.Cargo}");
        Console.WriteLine($"Sueldo Básico: {emp.SueldoBasico}");
        Console.WriteLine($"Adicional: {adicional}");
        Console.WriteLine($"Salario Final: {salarioFinal}");
        Console.WriteLine($"Años para jubilarse: {minAniosJubilacion}");

        Console.WriteLine($"TOTAL SALARIOS{total_salarios}");
    }
}
