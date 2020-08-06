using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class EmpresaTransporte
    {   
        public List<Cliente> clientes;
        int viajeLibre = 8500;
        int viajesTotal;
        int promedioTotal;
        public EmpresaTransporte(List<Cliente> clientes)
        {
            this.clientes = clientes;
        }
        public void facturar()
        {
            int clienteMayor = 0;
            int totalViajesClientes = 0;
            foreach (Cliente cli in clientes)
            {   
                int viajesFacturar = cli.getViajeAdicional();
                viajesTotal = viajesFacturar * 100 + viajeLibre;
                if (viajesFacturar > 30)
                {
                    int descuento = (viajesTotal * 10) / 100;
                    viajesTotal = viajesTotal - descuento;                    
                }
                Console.WriteLine(string.Format("Total en la factura de la empresa {0} es: $", cli.getNombre()) + viajesTotal);
                totalViajesClientes += viajesTotal;
                if (viajesTotal > clienteMayor)
                {
                    clienteMayor = viajesTotal;
                }
            }
            promedioTotal = totalViajesClientes / clientes.Count;  
            Console.WriteLine("El promedio total de lo abonado por clientes es: " + promedioTotal);
            Console.WriteLine("La Factura mayor es: $" + clienteMayor);
          
        }

    }
}
