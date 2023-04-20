using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructudaDeDatos.Ejercicio3
{
    internal static class MenuPrincipal
    {
        public static void Mostrar()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1-Alta de empleado");
            Console.WriteLine("2-Baja de empleado");
            Console.WriteLine("3-Modificar empleado");
            Console.WriteLine("4-Salir");

            while (true)
            {
                Console.WriteLine("ingrese su opción:");
                var ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out var opcion))
                {
                    Console.WriteLine("Ingrese un numero válido");
                    continue;
                }

                if (opcion > 1 || opcion > 4)
                {
                    Console.WriteLine("Ingrese 1-4");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        ModuloEmpleados.Alta();
                        break;

                    case 2:
                        ModuloEmpleados.Baja();
                        break;

                    case 3:
                        ModuloEmpleados.Modificar();
                        break;

                    case 4: //finalizar
                        return;
                }

                break;
            }


        }
    }
}
