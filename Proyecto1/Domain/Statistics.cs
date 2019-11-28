using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1.Domain
{
    class Statistics
    {
        public void showStatistics(List<DefinitivePerson> df) // Recibe la lista porque de ahi saca toda la información ya que es la definitiva.
        {
            Console.WriteLine("Cantidad de Empleados: {0}", df.Count());
            Console.WriteLine("Cantidad de Hombres: {0}", df.Count(r => r.Gender == "M"));
            Console.WriteLine("Cantidad de Mujeres: {0}", df.Count(r => r.Gender == "F"));
            Console.WriteLine("Cantidad de empleados mayores de 40 años: {0}", df.Count(r => r.Age > 40));
            Console.WriteLine(" ");
        }
    }
}
