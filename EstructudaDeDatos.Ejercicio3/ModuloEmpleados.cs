using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructudaDeDatos.Ejercicio3
{
    internal class ModuloEmpleados
    {
        internal static void Alta()
        {
            List<EmpleadoEnt> empleados = new List<EmpleadoEnt>();

            while (true)
            {
                //1) Pedir los datos para construir un objeto auto
                //2) agregarlo a la lista
                //3)preguntarle al usuario si quiere seguir o no,
                //4)si no, por ahora terminamos.
                //5)si si, seguimos

                EmpleadoEnt nuevoEmpleado = IngresarEmpleado();
                empleados.Add(nuevoEmpleado);
                Console.WriteLine("Se ha agregado un nuevo empleado.");
                Console.WriteLine($"Cantidad: {empleados.Count}");

                Console.WriteLine("¿Desea continuar? [S/N]");
                string continuar = null;
                while (continuar != "S" && continuar != "N")
                {
                    continuar = Console.ReadLine();
                }

                if (continuar == "N")
                {
                    break;
                }
            }

            EmpleadoEnt IngresarEmpleado()
            {
                EmpleadoEnt empleado = new EmpleadoEnt();
                while (true)
                {
                    //Legajo
                    empleado.Legajo = Ingreso.Entero("El legajo", 1, 999_999);

                    //Nombre
                    empleado.Nombre = Ingreso.Cadena("el nombre", 1, 30, soloLetras: true);

                    //Apellido
                    empleado.Apellido = Ingreso.Cadena("el apellido", 1, 30, soloLetras: true);

                    //Fecha de ingreso
                    empleado.FechaIngreso = Ingreso.Fecha("la fecha de ingreso", new DateTime(1950, 01, 01), DateTime.Now);

                    //Fecha de egreso
                    empleado.FechaEgreso = Ingreso.Fecha("la fecha de egreso", new DateTime(1950, 01, 01), DateTime.Now);


                    if (!empleado.ValidaEmpleado(out string error))
                    {
                        Console.WriteLine(error);
                        continue;
                    }

                    break;
                }

                return empleado;
            }

        }

        internal static void Baja()
        {
            throw new NotImplementedException();
        }

        internal static void Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
