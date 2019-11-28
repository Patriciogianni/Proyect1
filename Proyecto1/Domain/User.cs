using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    public class User
    {
        // Declaración de variables a utilizar.

        private string uName;
        private string password; // Será el legajo del usuario. 
        public string UName
        {
            get
            {
                return uName;
            }

            set
            {
                uName = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set // Una validación simple como para que escriba bien la contraseña.
            {
               
               if (!value.StartsWith("L")) // value es como si fuera un "this".
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
