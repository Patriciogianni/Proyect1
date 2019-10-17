using Proyecto1.Domain; // Llamar el paquete siempre 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    class Program
    {
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
        static void firstLogin()
        {

            User user = new User();

            Console.WriteLine("Escriba el nombre de usuario");
            user.Name = Console.ReadLine();

            do
            {
                Console.WriteLine("Escriba su contraseña");
                user.Password = Console.ReadLine();

            } while (!user.Password.StartsWith("L"));

            Console.WriteLine("Contraseña correcta");
            Console.WriteLine(" ");
            Console.WriteLine("Bienvenido {0} !!!", user.Name);
            Console.WriteLine(" ");
        }

        static void Main(string[] args)
        {
            printWelcomeMessage();
            firstLogin();
            Menu menu = new Menu();
            menu.showMenu();
        }
    }
}