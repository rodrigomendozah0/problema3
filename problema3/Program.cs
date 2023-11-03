using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.Pantallaprincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        opcion = Pantallas.sumar();
                        break;
                    case 2:
                        Console.Clear();
                        opcion = Pantallas.restar();
                        break;
                    case 3:
                        Console.Clear();
                        opcion = Pantallas.multiplicar();
                        break;
                    case 4:
                        Console.Clear();
                        opcion = Pantallas.dividir();
                        break;
                    case 0:                      
                    default:
                        opcion = Pantallas.Pantallaprincipal();
                        break;

                }
            } while (opcion != 5);
            Console.ReadKey();
        }
    }
}
