using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3
{
    internal class Pantallas
    {
        public static int Pantallaprincipal()
        {
            Console.Clear();
            Console.Write("" +
                            "======================\n" +
                            "Las cuatro operaciones\n" +
                            "======================\n" +
                            "1: Suma\n" +
                            "2: Resta\n" +
                            "3: Multiplicación\n" +
                            "4: División\n" +
                            "5: Salir\n" +
                            "======================\n" +
                            "Ingresa una opción: ");
            return getOpcion();
        }

        public static int sumar()
        {
            Console.Clear();
            Pantallaalta("Sumando ...\n");
            int suma = getsuma();

            Console.Write("============\n" +
                        "Resultado " + suma + "\n");

            Pantallabaja();

            int opcion = getOpcion();
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int restar()
        {
            Console.Clear();
            Pantallaalta("Restando ...\n");
            int resta = getResta();
            Console.Write("============\n" +
                        "Resultado " + resta + "\n");

            Pantallabaja();

            int opcion = getOpcion();
            if (opcion == 1) return 2;
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int multiplicar()
        {
            Console.Clear();
            Pantallaalta("Multiplicando ...\n");

            int producto = getMultiplicacion();

            Console.Write("============\n" +
                        "Resultado " + producto + "\n");

            Pantallabaja();

            int opcion = getOpcion();
            if (opcion == 1) return 3;
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int dividir()
        {

            Console.Clear();
            Pantallaalta("Dividiendo ...\n");
            int cociente = getDivision();
            Console.Write("============\n" +
                        "Resultado " + cociente + "\n");
            Pantallabaja();

            int opcion = getOpcion();
            if (opcion == 1) return 4;
            if (opcion == 2) return 0;
            return opcion;
        }

        private static int getsuma()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return Operaciones.suma(numero1, numero2);
        }
        private static int getResta()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return Operaciones.resta(numero1, numero2);
        }

        private static int getMultiplicacion()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return Operaciones.multiplicacion(numero1, numero2);
        }

        private static int getDivision()
        {
            int numero1 = Operaciones.getEntero("Numero 1: ");
            int numero2 = Operaciones.getEntero("Numero 2: ");
            return Operaciones.division(numero1, numero2);
        }

        private static void Pantallaalta(string texto)
        {
            Console.Write("" +
                                    "===========================================\n" +
                                    texto +
                                    "===========================================\n");
        }

        private static void Pantallabaja()
        {
            Console.Write("============================================\n" +
                                    "1: Limpiar | 2: Regresar Menú |\n" +
                                    "============================================\n" +
                                    "Ingresa una opción: ");
        }

        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
    }
}
