using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    class User
    {
        private string name;
        private string password;
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
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
               
               if (!value.StartsWith("L"))
               {
                 Console.WriteLine("Contraseña Incorrecta, ingrese nuevamente. Debe ser el numero de su legajo: L___");
                 password = value;   
               }
               else
               {
                 password = value;
               }     
            }
        }
    }
}
