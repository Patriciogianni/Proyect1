using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    [Serializable]
    public class Person
    {
        private int du;
        private string gender;
        private string lastName;
        private string name;
        private int age;
        private string dateBirth;
        private string codePerson;
        public int Du
        {
            get
            {
                return du;
            }

            set
            {
                du = value;
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
                age = value;
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

        public string CodePerson
        {
            get
            {
                return codePerson;
            }

            set
            {
                codePerson = value;
            }

        }

        public int generateCodePerson()
        {
            int code;
            Random random = new Random();
            code = random.Next(100, 1000);
            return code;
        }

        public void showPerson() // Muestro por patallla lo cargado.
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
            Console.WriteLine("Codigo de la persona : {0}\n", CodePerson);
            Console.WriteLine("Se ha guardado la persona en la base de datos\n");
            Console.WriteLine("-----------------------------------");
        }
    }
}