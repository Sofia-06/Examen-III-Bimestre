using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
   
    class Program
    {
        static string[,] agenda; // para 10 contactos 
        static int contactos = 0;
        static int contador = 0;
        static String[,] menu = new string[4, 3];
        
        static void Main(string[] args)
        {
            int op;
            
            string usuario = "Contacto no encontrado";
            do
            {
                try
                {
                    Console.WriteLine("Bienvenido, seleccione la opción que desee: ");
                    Console.WriteLine(" 1. Crear contactos: ");
                    Console.WriteLine(" 2. Mostrar contactos: ");
                    Console.WriteLine(" 3. Buscar contacto deseado: ");
                    Console.WriteLine(" 4. Salir: ");
                    Console.WriteLine("Ingrese la opción deseada:");
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Ingrese un numero correcto");
                    Console.WriteLine("Bienvenido, seleccione la opción que desee: ");
                    Console.WriteLine(" 1. Crear contactos: ");
                    Console.WriteLine(" 2. Mostrar contactos: ");
                    Console.WriteLine(" 3. Buscar contacto deseado: ");
                    Console.WriteLine(" 4. Salir: ");
                    Console.WriteLine("Ingrese la opción deseada:");
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                
                if (op == 1)
                {
                    contactos = PedirNoContactos();
                    Console.Clear();
                    agenda = new string[10, contactos];
                    Guardarcontacto();
                    Guardarcontacto();
                    MostrarContactos();
                    Console.Clear();
                }
                
                else if (op == 2)
                {
                    MostrarContactos();
                    Console.ReadLine();
                    op = 1;
                    Console.Clear();
                }
                
                else if (op == 3)
                {
                    BuscarContactos();
                }
                else if (op == 4)
                {
                    Environment.Exit(0);
                }

            } while (op == 1);
            Console.ReadKey();
        }
        static int PedirNoContactos()
        {
            Console.Write("Cuantos contactos desea agregar: ");
            return int.Parse(Console.ReadLine());
        }
        static string PedirDatos(string linea)
        {
            string dato = "";
            dato = "Ingrese " + linea + ":";
            return dato;
        }
        static void Guardarcontacto()
        {
            if (contador < contactos)
            {
                Console.Write(PedirDatos("Nombre"));
                agenda[0, contador] = Console.ReadLine();
                Console.Write(PedirDatos("Apellido"));
                agenda[1, contador] = Console.ReadLine();
                Console.Write(PedirDatos("Direccion"));
                agenda[2, contador] = Console.ReadLine();
                Console.Write(PedirDatos("Telefono"));
                agenda[3, contador] = Console.ReadLine();
                contador++;
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Agenda llena\n");
            }
        }
        static void MostrarContactos()
        {
            for (int f = 0; f < contador; f++)
            {
                Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");
            }
        }
        
        static void BuscarContactos()
        {
            string buscar = "";
            string buscar2 = "";
            string contacto = "Contacto no encontrado";
            Console.Write("Ingrese el nombre del contacto que desea buscar: ");
            buscar = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            buscar2 = Console.ReadLine();
            for (int f = 0; f < 10; f++)
            {
                if (buscar == menu[0, f] && buscar2 == menu[1, f])
                {
                    contacto = menu[0, f] + "--" + menu[1, f] + "--" + menu[2, f] + "--" + menu[3, f];
                }
            }
        }
    }

}
    

