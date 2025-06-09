using System.Diagnostics;
using EspacioCalculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        double numTrabajado;

        Calculadora calculadora = new Calculadora();

        do
        {
            Console.Write(" 1-Sumar \n 2-Restar \n 3-Multiplicar \n 4-Dividir \n 5-Limpiar \n Ponga su respuesta:");
            string entrada = Console.ReadLine();
            numero = Convert.ToInt32(entrada);

            Console.Write("Ingrese un número: ");
            entrada = Console.ReadLine();
            numTrabajado = Convert.ToDouble(entrada);

            switch (numero)
            {
                case 1:
                    calculadora.Sumar(numTrabajado);
                    break;
                case 2:
                    calculadora.Restar(numTrabajado);
                    break;
                case 3:
                    calculadora.Multiplicar(numTrabajado);
                    break;
                case 4:
                    calculadora.Dividir(numTrabajado);
                    break;
                case 5:
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
