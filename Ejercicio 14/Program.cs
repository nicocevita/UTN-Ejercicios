using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();           
            Cliente clienteUno = new Cliente();
            clienteUno.setNombre("Los Nenes");
            clienteUno.setViajeAdicional(18);           
            Cliente clienteDos = new Cliente();
            clienteDos.setNombre("Software Industrial SRL");
            clienteDos.setViajeAdicional(150);
            Cliente clienteTres = new Cliente();
            clienteTres.setNombre("Fiambreria");
            clienteTres.setViajeAdicional(400);
            Cliente clienteCuatro = new Cliente();
            clienteCuatro.setNombre("Papa John's");
            clienteCuatro.setViajeAdicional(30);
            Cliente clienteCinco = new Cliente();
            clienteCinco.setNombre("Los Timbales");
            clienteCinco.setViajeAdicional(13);
            clientes.Add(clienteUno);
            clientes.Add(clienteDos);
            clientes.Add(clienteTres);
            clientes.Add(clienteCuatro);
            clientes.Add(clienteCinco);
            EmpresaTransporte empresaUno = new EmpresaTransporte(clientes);
            empresaUno.facturar();
            Console.ReadKey();
        }        
    }
}
