using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pajaro pajaro1 = new Pajaro();
            pajaro1.SetEspecie("Gorrion");
            pajaro1.SetEdad(6);
            pajaro1.SetPeso(28);
            pajaro1.SetAltura(14);
            pajaro1.SetEnvergadura(20);
            pajaro1.Comer();
            pajaro1.Tomar();            
        }
    }
}
