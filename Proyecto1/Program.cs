using Proyecto1.Domain; // Llamar el paquete en donde estan todos los objetos que voy a usar.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
        // Se imprime el primer mensaje de la aplicación dando la bienvenida con la fecha y hora del momento.
        static void printWelcomeMessage()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine("BIENVENIDO AL SISTEMA DE ADMINISTRACION DE PERSONAL SCALA RH CONSULTING");
            Console.WriteLine(" ");
            Console.WriteLine("Se detecta que no tiene un usuario activo en la aplicacion, debe generarlo para realizar una operacion");
            Console.WriteLine(" ");
        }

        // Funcion que ejecuta todo el programa inicializando a un usuario que recien ingresa.
        static void firstLogin()
        {

            User user = new User();

            Console.WriteLine("Escriba el nombre de usuario");
            user.UName = Console.ReadLine();

            do
            {
                Console.WriteLine("Escriba su contraseña");
                user.Password = Console.ReadLine();

            } while (!user.Password.StartsWith("L"));

            Console.WriteLine("Contraseña correcta");
            Console.WriteLine(" ");
            Console.WriteLine("Bienvenido {0} !!!", user.UName);
            Console.WriteLine(" ");

            Menu menu = new Menu(); // Inicializa todo el menu
            menu.showMenu(user); // Se muestra trayendole el usuario creado.
        }

        static void Main(string[] args)
        {
            printWelcomeMessage();
            firstLogin();
        }
    }
}