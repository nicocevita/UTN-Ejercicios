using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Empresa
    {
        public List<Cliente> clientes = new List<Cliente>();

        public void ingresarClientes()
        {
            int codigoCli = ingresarCodigoCliente();
            while (codigoCli != 0)
            {
                Cliente cliente = new Cliente();
                cliente.SetCodigoCliente(codigoCli);                
                cliente.SetTipoAbono(ingresarTipoAbono());                
                cliente.SetDuracionLlamada(ingresarDuracionLlamada());               
                clientes.Add(cliente);
                codigoCli = ingresarCodigoCliente();
            }
        }

        public char ingresarTipoAbono()
        {
            Console.WriteLine("Ingrese Tipo de abono: ");
            return Char.Parse(Console.ReadLine());
        }

        public int ingresarDuracionLlamada()
        {
            Console.WriteLine("Ingrese Duracion de la llamada: ");
            return Int32.Parse(Console.ReadLine());
        }

        public int ingresarCodigoCliente()
        {
            Console.WriteLine("Ingrese CODIGO CLIENTE: ");
            return Int32.Parse(Console.ReadLine());            
        }

       
        public void calcularConsumo()
        {
            
            foreach (Cliente cli in clientes)
            {
                double totalConsumo = 0;
                char abono = cli.GetTipoAbono();
                int minutosLlamada = cli.GetDuracionLlamada();                
                if (abono == 'A')
                {
                    totalConsumo = minutosLlamada * 2;
                }
                else if (abono == 'B')
                {
                    if(minutosLlamada < 6)
                    {
                        totalConsumo = minutosLlamada * 2;
                    }
                    else
                    {
                        totalConsumo = (5 * 2) + ((minutosLlamada - 5) * 1.5);
                    }              
                }
                else if (abono == 'C')
                {
                    if(minutosLlamada < 11)
                    {
                        totalConsumo = minutosLlamada;
                    }
                    else
                    {
                        totalConsumo = 10;
                    }
                }
                Console.WriteLine("El total consumo es: " + totalConsumo);
            }           
            Console.ReadKey();
        }
    }
}
