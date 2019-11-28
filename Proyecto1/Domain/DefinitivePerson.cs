using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    [Serializable] // Indica que esta clase se puede transformar en un archivo.
    public class DefinitivePerson : Person // Hereda de Person, DefinitivePerson es una Person.
    {
        // Variable a utilizar.

        private string fileDef;
        public string FileDef
        {
            get
            {
                return fileDef;
            }
            set
            {
                fileDef = value;
            }

        }

        public void showDefPerson() // Me muestra la definitivePerson que se ha creado para que el usuario vea. 
        {
            Console.WriteLine(" ");
            Console.WriteLine("Persona Definitiva");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("DU: {0}\n", Du);
            Console.WriteLine("Genero: {0}\n", Gender);
            Console.WriteLine("Apellido: {0}\n", LastName);
            Console.WriteLine("Nombre: {0}\n", Name);
            Console.WriteLine("Edad: {0}\n", Age);
            Console.WriteLine("Fecha de Nacimiento: {0}\n", DateBirth);
            Console.WriteLine("Codigo de la persona : {0}\n", Code);
            Console.WriteLine("Legajo: {0}\n", FileDef);
            Console.WriteLine("-----------------------------------");
        }

    }
}