using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Cliente
    {
        private int numeroCliente;
        private char tipoAbono;
        private int duracionLlamada;

        public int GetCodigoCliente()
        {
            return this.numeroCliente;
        }

        public void SetCodigoCliente(int numeroCliente)
        {
            if(numeroCliente > 10000 && numeroCliente < 100000)
            {
                this.numeroCliente = numeroCliente;
            }            
        }

        public char GetTipoAbono()
        {
            return this.tipoAbono;
        }

        public void SetTipoAbono(char tipoAbono)
        {
            if(tipoAbono.Equals('A') || tipoAbono.Equals('B')  || tipoAbono.Equals('C'))
            {
                this.tipoAbono = tipoAbono;
            }            
        }

        public int GetDuracionLlamada()
        {
            return this.duracionLlamada;
        }

        public void SetDuracionLlamada(int duracionLlamada)
        {
            this.duracionLlamada = duracionLlamada;
        }
    }
}
