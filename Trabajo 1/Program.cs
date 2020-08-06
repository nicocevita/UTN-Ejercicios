using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============================EJERCICIO 3===============================
            //int n1; 
            //int n2;
            //Console.WriteLine("Ingrese un numero: ");
            //n1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese otro pls bb: ");
            //n2 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("La suma entre " + n1 + " y " + n2 + " da como resultado " + (n1 + n2));
            //Console.ReadKey();

            //===============================EJERCICIO 4===============================

            //int v1;
            //int v2;

            //Console.WriteLine("Ingrese un numero: ");
            //v1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese un numero: ");
            //v2 = Int32.Parse(Console.ReadLine());

            //if (v2 == 0)
            //{
            //    Console.WriteLine("No se puede dividir por cero");
            //}
            //else
            //{
            //    Console.WriteLine(v1 + "/" + v2 + "=" + (v1/v2));
            //}

            //Console.ReadKey();

            //===============================EJERCICIO 5===============================

            //string a = "HOLA";
            //string b = "CHAU";
            //string c;


            //Console.WriteLine(a + b);
            //Console.ReadKey();

            //c = a;
            //a = b;
            //b = c;

            //Console.WriteLine(a + b);
            //Console.ReadKey();

            //===============================EJERCICIO 6===============================

            //int a;
            //int b;
            //int c;

            //Console.WriteLine("Ingrese un numero: ");
            //a = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese un numero: ");
            //b = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese un numero: ");
            //c = Int32.Parse(Console.ReadLine());

            //if (a > b) 
            //{
            //    if (c > a)
            //    {
            //        Console.WriteLine(c);
            //    }
            //    else 
            //    {
            //        Console.WriteLine(a);
            //    }

            //}
            //else 
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c);
            //    }
            //}
            //Console.ReadKey();

            //===============================EJERCICIO ===============================


            //string[] diaSemana = new string[] {"Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado"};

            //int Num;


            //Console.WriteLine("Ingrese numero de la semana: ");
            //Num = Int32.Parse(Console.ReadLine());

            //if (Num > 0 && Num < 8) 
            //{
            //    if(Num == 1)
            //    {
            //        Console.WriteLine(diaSemana[0]);
            //    }
            //    if(Num == 2)
            //    {
            //        Console.WriteLine(diaSemana[1]);
            //    }
            //    if(Num == 3)
            //    {
            //        Console.WriteLine(diaSemana[2]);
            //    }
            //    if(Num == 4)
            //    {
            //        Console.WriteLine(diaSemana[3]);
            //    }
            //    if(Num == 5)
            //    {
            //        Console.WriteLine(diaSemana[4]);
            //    }
            //    if(Num == 6)
            //    {
            //        Console.WriteLine(diaSemana[5]);
            //    }
            //    if(Num == 7)
            //    {
            //        Console.WriteLine(diaSemana[6]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("ERROR: Ingrese numero del 1 al 7");
            //}

            //Console.ReadKey();

            //===============================EJERCICIO 8===============================

            //int a;

            //Console.WriteLine("Ingrese numero: ");
            //a = Int32.Parse(Console.ReadLine());

            //if((a % 2) == 0)
            //{
            //    Console.WriteLine("Es par");
            //}
            //else
            //{
            //    Console.WriteLine("Es inpar");
            //}

            //Console.ReadKey();

            //===============================EJERCICIO 9===============================

            //int n1;
            //int n2;
            //bool sonIguales;

            //Console.WriteLine("Ingrese numero: ");
            //n1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese otro numero: ");
            //n2 = Int32.Parse(Console.ReadLine());

            //sonIguales = (n1 == n2);

            //if(sonIguales)
            //{
            //    Console.WriteLine("Son Iguales");
            //}
            //else
            //{
            //    Console.WriteLine("No son iguales");
            //}

            //Console.ReadKey();

            //===============================EJERCICIO 10===============================


            //int edad;
            //int altura;
            //bool comprobacion;
            //string nombre;

            //Console.WriteLine("Ingrese nombre: ");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese la EDAD: ");
            //edad = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la ALTURA en cm: ");
            //altura = Int32.Parse(Console.ReadLine());

            //comprobacion = edad > 6 && altura > 139;

            //if (comprobacion)
            //{
            //    Console.WriteLine(nombre + " puede subir");
            //}
            //else
            //{
            //    Console.WriteLine(nombre + " no puede subir");
            //}

            //Console.ReadKey();



            //===============================EJERCICIO11===============================

            //int edad;
            //int altura;
            //bool comprobacion;
            //string nombre;

            //Console.WriteLine("Ingrese nombre: ");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese la EDAD: ");
            //edad = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la ALTURA en cm: ");
            //altura = Int32.Parse(Console.ReadLine());

            //comprobacion = edad > 6 || altura > 139;

            //if (comprobacion)
            //{
            //    Console.WriteLine(nombre + " puede subir");
            //}
            //else
            //{
            //    Console.WriteLine(nombre + " no puede subir");
            //}

            //Console.ReadKey();

            //===============================EJERCICIO12===============================

            //int n; 
            //bool estaEnA;
            //bool estaEnB;
            //bool estaEnAmbos;
            //bool noEstaEnNinguno;

            //Console.WriteLine("Ingrese numero: ");
            //n = Int32.Parse(Console.ReadLine());

            //estaEnA = n > -1 && n < 10;
            //estaEnB = (n % 2) != 0;
            //estaEnAmbos = estaEnA && estaEnB;
            //noEstaEnNinguno = !estaEnA && !estaEnB;

            //if (estaEnA)
            //{
            //    Console.WriteLine("Es de un solo digito");
            //}
            //if (estaEnB)
            //{
            //    Console.WriteLine("Es Impar");
            //}
            //if (estaEnAmbos)
            //{
            //    Console.WriteLine("Es impar y tiene un solo digito");
            //}
            //else
            //{
            //    Console.WriteLine("no es impar y tiene mas de 1 digito");
            //}
            //Console.ReadKey();

            //int n;
            //bool estaEnA;
            //bool estaEnB;
            //bool estaEnAmbos;
            //bool noEstaEnNinguno;

            //Console.WriteLine("Ingrese numero: ");
            //n = Int32.Parse(Console.ReadLine());

            //estaEnA = n > -1 && n < 10;
            //estaEnB = (n % 2) != 0;
            //estaEnAmbos = estaEnA && estaEnB;
            //noEstaEnNinguno = n > 9 && !estaEnB;


            //if (estaEnAmbos)
            //{
            //    Console.WriteLine("Es impar y tiene un solo digito");
            //}
            //else if (estaEnA)
            //{
            //    Console.WriteLine("Es de un solo digito");
            //}
            //else if (estaEnB)
            //{
            //    Console.WriteLine("Es Impar");
            //}
            //else if (noEstaEnNinguno)
            //{
            //    Console.WriteLine("no es impar y tiene mas de 1 digito");
            //}
            //Console.ReadKey();


            //===============================PRACTICO N2===============================
            //=========================================================================
            //===============================EJERCICIO 1===============================

            //int x;

            //for (x =0; x < 101; x++)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.ReadKey();

            //for (x=100; x>0; x--)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.ReadKey();

            //===============================EJERCICIO 2===============================



            //===============================EJERCICIO 3===============================

            //int a;
            //int b;
            //int x = 0;
            //int i;

            //Console.WriteLine("Ingrese numero: ");
            //a = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese otro numero: ");
            //b = Int32.Parse(Console.ReadLine());

            //for (i = 1; i <= b; i++)
            //{
            //    x = a + x;

            //    Console.WriteLine(string.Format("Vuelta:{0}  Valor:{1}", i, x));
            //} 

            //Console.WriteLine(string.Format("El valor total es :{0}", x));

            //Console.ReadKey(); 

            //===============================EJERCICIO 4===============================

            //int a;
            //int i;
            //int x = 0;

            //Console.WriteLine("Ingrese un numero entre 2 y 9: ");
            //a = Int32.Parse(Console.ReadLine());

            //if (a <= 9 && a >= 2)
            //{
            //    for(i=1; i <= 10; i++)
            //    {
            //        x = a * i;
            //        Console.WriteLine(string.Format("Los multiplos de {0} son: {1} ", a, x));
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("TE DIJE ENTRE 2 Y 9 CAPO, CERRADO POR RANCIO, HASTA LA PROXIMA");
            //}
            //Console.ReadKey();

            //===============================EJERCICIO 5===============================

            //int mayor = -99, menor = 99, i, n, numero;

            //Console.Write("Ingrese la cantidad de numeros a comparar: ");
            //n = Int32.Parse(Console.ReadLine());

            //for (i = 0; i < n; i++)
            //{
            //    Console.Write((i + 1) + " numero: ");

            //    numero = Int32.Parse(Console.ReadLine());

            //    if (mayor < numero)
            //    {
            //        mayor = numero;
            //    }

            //    if (menor > numero)
            //    {
            //        menor = numero;
            //    }
            //}

            //Console.WriteLine("El numero menor es: " + menor);

            //Console.ReadKey();

            //===============================EJERCICIO 6===============================

            //int n1;
            //int x = 20;
            //int numeros = 0;
            //int i;


            //Console.Write("Ingrese los numeros a promediar: ");
            //n1 = Int32.Parse(Console.ReadLine());

            //for (i = 1; i <= n1; i++)
            //{                     

            //    if (numeros <= x + numeros)

            //    {
            //        Console.WriteLine(string.Format("Numero {0}: ", i));
            //        numeros = Int32.Parse(Console.ReadLine());
            //        x = x - numeros;                                                                           // NO VA
            //    }
            //    else
            //    {
            //    Console.WriteLine("La cantidad supera el promedio final");
            //        break;
            //    }
            //    if (x == 0)
            //    {

            //        Console.WriteLine("Total valores leidos: " + n1);
            //        break;
            //    }

            //}
            //int NumerosIngresado;
            //int CantidadNumerosIngresados = 1;
            //int acumulado = 0;
            //int i;
            //int promedio = 0;          

            //for (i = 1; promedio<20; i++)
            //{
            //    Console.WriteLine("Ingresar numero: ");
            //    NumerosIngresado = Int32.Parse(Console.ReadLine());
            //    acumulado = NumerosIngresado + acumulado;
            //    promedio = acumulado / CantidadNumerosIngresados;     
            //    CantidadNumerosIngresados++;
            //}
            //if (promedio < 20)
            //{
            //    Console.WriteLine("Cantidad de valores leidos: " + CantidadNumerosIngresados);
            //}
            //else
            //{
            //    Console.WriteLine("El Promedio final supera 20");
            //}
            //Console.ReadKey();

            //===============================EJERCICIO 7===============================

            //Random azar = new Random();
            //int i;
            //int a;
            //a = azar.Next(0, 101);
            //int x = 0;            

            //for (i = 0; x != a; i++)
            //{
            //    Console.WriteLine("Ingrese nuevo numero: ");
            //    x = Int32.Parse(Console.ReadLine());

            //    if (x < a)
            //    {
            //        Console.WriteLine("Tu numero es menor, intenta otra vez.");
            //    }
            //    else if (x > a)
            //    {
            //        Console.WriteLine("Tu numero es mayor, intenta otra vez.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("CORRECTO!");

            //    }
            //    Console.WriteLine(string.Format("Numero de intentos {0}", i));
            //}

            //Console.ReadKey();

            //===============================EJERCICIO 8===============================

            //int[] n1 = { 4, 5, 6 };
            //int[] n2 = { 5, 4, 7 };
            //int[] n3 = { 3, 9, 8 };
            //int[] n4 = { 9, 4, 2 };
            //int[] n5 = { 7, 6, 4 };
            //double promedio1 = 0;
            //double promedio2 = 0;
            //double promedio3 = 0; 
            //double promedio4 = 0;
            //double promedio5 = 0;

            //double suma = 0;

            //foreach (double n1a in n1)
            //{
            //    suma += n1a;
            //    promedio1 = suma / n1.Length;                
            //}
            //foreach (double n2a in n2)
            //{
            //    suma += n2a;
            //    promedio2 = suma / n2.Length;                
            //}
            //foreach (double n3a in n3)
            //{
            //    suma += n3a;
            //    promedio3 = suma / n3.Length;                
            //}
            //foreach (double n4a in n4)
            //{
            //    suma += n4a;
            //    promedio4 = suma / n4.Length;                
            //}
            //foreach (double n5a in n5)
            //{
            //    suma += n5a;
            //    promedio5 = suma / n5.Length;                
            //}
            //Console.WriteLine("El 1romedio es: " + promedio1);
            //Console.WriteLine("El 1romedio es: " + promedio2);
            //Console.WriteLine("El 1romedio es: " + promedio3);
            //Console.WriteLine("El 1romedio es: " + promedio4);
            //Console.WriteLine("El 1romedio es: " + promedio5);

            //Console.ReadKey();

            //===============================EJERCICIO 9===============================

            //Random random = new Random();

            //int n1 = random.Next(1, 11);
            //int promedio = 0;
            //int suma = 0;
            //int[] n = new int[n1];
            //int[] promedios = new int[n1];
            //int posicionPromedioMayor = 0;
            //int sumaTotal = 0;
            //string pito;
            //bool pito2;
            //int pito3;


            //for (int i = 0; i != n1; i++)
            //{
            //    Console.WriteLine(string.Format("Ingresar {0} conjunto de numeros", n1));
            //    for (int x = 0; x != n1; x++)
            //    {
            //        Console.WriteLine(string.Format("Ingresar el {0} numero de solamente 1 digito:", (x + 1)));
            //        pito = Console.ReadLine();
            //        //n[x] = Int32.Parse(pito.Trim());
            //        pito2 = Int32.TryParse(pito.Trim(), out pito3); //Preguntarle a Eri si no me acuerdo porque esto lo hizo ella.
            //        if (pito2)
            //        {
            //            n[x] = pito3;
            //        }
            //        else
            //        {
            //            n[x] = 0;
            //            Console.WriteLine("Dale tonto, toi chiquito ahora");
            //        }
            //    }
            //    foreach (int n1a in n)
            //    {
            //        suma += n1a;
            //        sumaTotal += n1a;
            //    }
            //    promedio = suma / n.Length;
            //    promedios[i] = promedio;
            //    suma = 0;
            //}
            //for (int k = 0; k != n1; k++)
            //{
            //    if (promedios[k] > posicionPromedioMayor)
            //    {
            //        posicionPromedioMayor = promedios[k];
            //    }
            //}
            //Console.WriteLine("Suma total de juegos: " + sumaTotal);

            //Console.WriteLine("El promedio mayor es: " + posicionPromedioMayor);

            //Console.ReadKey();

            //===============================EJERCICIO 10===============================

            //int n1;
            //int n2;
            //string op = "";
            //int resultado = 0;

            //Console.WriteLine("Ingrese el operador: ");
            //op = Console.ReadLine();
            //Console.WriteLine("Ingrese el primer valor: ");
            //n1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el segundo valor: ");
            //n2 = Int32.Parse(Console.ReadLine());

            //switch (op)
            //{
            //    case "+": resultado = n1 + n2; Console.WriteLine("Resultado: " + resultado); break;
            //    case "-": resultado = n1 - n2; Console.WriteLine("Resultado: " + resultado); break;
            //    case "/": if (n2 == 0)
            //        {
            //            Console.WriteLine("No se pude dividir por 0"); break;
            //        }
            //        else
            //        {
            //            resultado = n1 / n2; Console.WriteLine("Resultado: " + resultado); break;
            //        }
            //    case "*": resultado = n1 * n2; Console.WriteLine("Resultado: " + resultado);  break;
            //    default: Console.WriteLine("Operador no valido, no seas gil"); break;
            //}

            //Console.ReadKey();

            //===============================EJERCICIO 11===============================

            //bool resultado1 = esMultiplo(5, 3);
            //bool resultado2 = esMultiplo(15, 5);
            //Console.WriteLine("resultado es " + resultado1);
            //Console.WriteLine("resultado es " + resultado2);

            //Console.ReadKey();

            //===============================EJERCICIO 12===============================


            //bool resultado1 = esPar(5);
            //bool resultado2 = esPar(2);
            //Console.WriteLine("resultado es " + resultado1);
            //Console.WriteLine("resultado es " + resultado2);

            //Console.ReadKey();

            //===============================EJERCICIO 13===============================

            //int resultado = binToDec("11AE");

            //Console.WriteLine(resultado);
            //Console.ReadKey();

            //===============================EJERCICIO 14===============================



        }

        //===============================EJERCICIO 11===============================
        //public static bool esMultiplo(int num1, int num2)
        //{
        //    return (num1 % num2) == 0;    
        //}
        //===============================EJERCICIO 12===============================
        //public static bool esPar(int valor)
        //{
        //    return Convert.ToBoolean(valor % 2 == 0);
        //}
        //public static int binToDec (string numeroBinario)
        //{
        //    // TOINT32: Decimal es la base en la que se convierte; El segundo parametro que recibe es la base de origen. 
        //    return Convert.ToInt32(numeroBinario, 2);
        //}

        


    }

}

