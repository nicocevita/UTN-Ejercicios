using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Cliente
    {
        private string nombre;
        private int viajeAdicional = 0;

        public void setNombre(string nombre)
        {
            if (nombre.Contains("@"))
            {
                this.nombre = "";
            }
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setViajeAdicional(int viajeAdicional)
        {
            this.viajeAdicional = viajeAdicional;
        }
        public int getViajeAdicional()
        {
            return this.viajeAdicional;
        }
    }
}
