using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3._2
{
    class Paquete
    {
        private double peso;
        private char categoria;

        public double GetPeso()
        {
            return this.peso;
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
            this.SetCategoria(peso);
        }
        private void SetCategoria(double peso)
        {
            if(peso < 1)
            {
                this.categoria = 'A';
            }
            else if(peso <= 10)
            {
                this.categoria = 'B';
            }
            else if(peso <= 50)
            {
                this.categoria = 'C';
            }
        }
        public char GetCategoria()
        {
            return this.categoria;
        }
    }
}
