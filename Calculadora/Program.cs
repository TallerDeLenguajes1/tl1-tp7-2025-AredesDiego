using System.Diagnostics;
using EspacioCalculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 0;
        double numTrabajado = 0;

        Calculadora calculadora = new Calculadora();

        do
        {
            Console.Write(" 1-Sumar \n 2-Restar \n 3-Multiplicar \n 4-Dividir \n 5-Limpiar \n Ponga su respuesta:");
            string entrada = Console.ReadLine();
            numero = Convert.ToInt32(entrada);

            Calculadora.Operacion operacion = (Calculadora.Operacion)numero;

            if(operacion != Calculadora.Operacion.Limpiar)
            {
                Console.Write("Ingrese un número: ");
                entrada = Console.ReadLine();
                numTrabajado = Convert.ToDouble(entrada);
            }

            switch (operacion)
            {
                case Calculadora.Operacion.Sumar:
                    calculadora.Sumar(numTrabajado);
                    break;
                case Calculadora.Operacion.Restar:
                    calculadora.Restar(numTrabajado);
                    break;
                case Calculadora.Operacion.Multiplicar:
                    calculadora.Multiplicar(numTrabajado);
                    break;
                case Calculadora.Operacion.Dividir:
                    calculadora.Dividir(numTrabajado);
                    break;
                case Calculadora.Operacion.Limpiar:
                    calculadora.Limpiar();
                    break;

                default:
                    Console.WriteLine("Invalido");
                    break;
            }
            
            Console.WriteLine($"Su resultado es: {calculadora.Resultado}");
            Console.WriteLine(" 1-Continuar \n 0-Salir \n Ponga su respuesta:");

            entrada = Console.ReadLine();
            numero = Convert.ToInt32(entrada);
            
        } while (numero == 1);
    }
}
