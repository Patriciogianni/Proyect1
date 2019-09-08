using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    class Validation
    {
        public void validationUserPassword(User u)
        {
            do
            {
                Console.WriteLine("Escriba su contraseña");
                u.Password = Console.ReadLine();

                if (u.Password.StartsWith("L"))
                {
                    Console.WriteLine("Contraseña correcta");
                    Console.WriteLine(" ");
                    Console.WriteLine("Bienvenido {0} !!!", u.Name);
                    Console.WriteLine(" ");
                    break;
                }

                if (u.Password.StartsWith("0") || u.Password == string.Empty || Convert.ToInt32(u.Password) > 1)
                {
                    Console.WriteLine("Contraseña Incorrecta, ingrese nuevamente. Debe ser el numero de su legajo: L___");
                }

            } while (u.Password.StartsWith("0") || u.Password.Equals("") || Convert.ToInt32(u.Password) > 1);
        }
    }
}
