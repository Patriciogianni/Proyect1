using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    [Serializable] // Indica que esta clase se puede transformar en un archivo.
    public class File
    {
        // Variables a utilizar. 

        private string idFile;
        private Person person; // Es una Person y representa el codigo de la persona.

        public string IdFile
        {
            get
            {
                return idFile;
            }

            set
            {
                idFile = value;
            }

        }
        public Person Person
        {
            get
            {
                return person;
            }

            set
            {
                person = value;
            }

        }
        public void toString() // Mostrar el legajo y el codigo de la persona a la que le fue asignado ese legajo. 
        {
            Console.WriteLine("Id del legajo: {0}\n", IdFile);
            Console.WriteLine("Codigo de la persona : {0}\n", Person.Code); // Hace referencia al Person del setter.
        }
    }
}