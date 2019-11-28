using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    [Serializable] // Indica que esta clase se puede transformar en un archivo.
    public class Person 
    {
        // Variables a utilizar.

        private int du;
        private string gender;
        private string lastName;
        private string name;
        private int age;
        private string dateBirth;
        private string code;
        private DateTime personDate;
        private User userApp; // Será de tipo User. 

        public int Du
        {
            get
            {
                return du;
            }

            set
            {
                if (value < 1000000)
                {
                    Console.WriteLine("DU incorrecto, escribalo de nuevo");
                }
                else
                {
                    du = value;
                }
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }

        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }

        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        public int Age
        {
            get
            {
                return age;
            }
             
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Los empleados no pueden ser menores de edad");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string DateBirth
        {
            get
            {
                return dateBirth;
            }

            set
            {
                dateBirth = value;
            }

        }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }

        }

        public DateTime PersonDate
        {
            get
            {
                return personDate;
            }

            set
            {
                personDate = value;
            }

        }

        public User UserApp
        {
            get
            {
                return userApp;
            }

            set
            {
                userApp = value;
            }
        }

        public Person generateCode(Person p) // Se general el codigo de la persona de forma aleatoria.
        {
            int Code;
            Random random = new Random();
            Code = random.Next(100, 1000); // Que el numero aleatorio sea entre 100 y 1000
            p.Code = Code.ToString("00000"); // El codigo que se crea se le asigna al codigo de la persona con "00000" al principio
            return p;
            //return Code;
        }

        public void show() // Muestro por patallla la persona cargada para que el usaurio se fije.
        {
            Console.WriteLine(" ");
            Console.WriteLine("Estos son los Datos Cargados...");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("DU: {0}\n", Du);
            Console.WriteLine("Genero: {0}\n", Gender);
            Console.WriteLine("Apellido: {0}\n", LastName);
            Console.WriteLine("Nombre: {0}\n", Name);
            Console.WriteLine("Edad: {0}\n", Age);
            Console.WriteLine("Fecha de Nacimiento: {0}\n", DateBirth);
            Console.WriteLine("Codigo: {0}\n", Code);
            Console.WriteLine("Día Cargado: {0}\n", PersonDate);
            Console.WriteLine("Usuario trabajador: {0} - {1}\n", UserApp.Password, userApp.UName); // El usuario que cargo al principio de todo.
            Console.WriteLine("Se ha guardado la persona en la base de datos\n");
            Console.WriteLine("-----------------------------------");
        }
    }
}