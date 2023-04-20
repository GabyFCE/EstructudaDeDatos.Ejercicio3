using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EstructudaDeDatos.Ejercicio3
{
    internal class EmpleadoEnt
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public int Antiguedad
        {
            get
            {
                if (FechaEgreso != null)
                {
                    return (int)FechaEgreso.Year - (int)FechaEgreso.Year;
                }
                else
                {
                    return (int)DateTime.Now.Year - (int)FechaEgreso.Year;
                }

            }

        }



        internal bool ValidaEmpleado(out string error)
        {
            error = null;

            
            if(FechaIngreso > DateTime.Now)
            {
                error = "La fecha de ingreso es superior a la fecha actual";
                return false;
            }
            if(Antiguedad >= 65)
            {
                error = "La antiguedad es mayor o igual a 65 años";
                return false;
            }
         
            if (FechaEgreso != null && FechaEgreso > DateTime.Now)
            {
                error = "La fecha de egreso es superior a la fecha actual";
                return false;
            }
            if (FechaEgreso != null && FechaEgreso < FechaIngreso)
            {
                error = "La fecha de egreso es inferior a la fecha de ingreso";
                return false;
            }


            return true;
        }
    }
}
