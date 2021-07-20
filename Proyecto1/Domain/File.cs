using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    [Serializable]
    public class File
    {
        private string idFile;
        private Person person;

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
        public void toString()
        {
            Console.WriteLine("Id del legajo: {0}\n", IdFile);
            Console.WriteLine("Codigo de la persona : {0}\n", Person.CodePerson);
        }
    }
}