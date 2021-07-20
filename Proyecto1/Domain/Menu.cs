using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Para el uso de archivo
using System.Xml.Serialization;


namespace Proyecto1.Domain
{
    class Menu
    {
        private static int opcion;
        private static string listDesition;

        static Person createPerson()
        {
            Person person = new Person();

            do
            {
                Console.WriteLine("Escribe el DU");
                person.Du = Convert.ToInt32(Console.ReadLine());

                if (person.Du < 1000000)
                {
                    Console.WriteLine("DU incorrecto, escribalo de nuevo");
                }

            } while (person.Du < 1000000);

            Console.WriteLine("Escribe el genero: M / F");
            person.Gender = Console.ReadLine();

            Console.WriteLine("Escribe el apellido");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Escribe el Nombre completo");
            person.Name = Console.ReadLine();

            do
            {
                Console.WriteLine("Escribe la Edad");
                person.Age = Convert.ToInt32(Console.ReadLine());

                if (person.Age < 18)
                {
                    Console.WriteLine("Los empleados no pueden ser menores de edad");
                }

            } while (person.Age < 18);

            Console.WriteLine("Escriba la fecha de nacimiento con formato: dia/mes/año");
            person.DateBirth = Console.ReadLine();

            person.CodePerson = person.generateCodePerson().ToString("00000");

            person.showPerson(); // Me muestra la persona completa para verificar que este bien cargado.

            return person;
        }
        static File createFile(List<Person> personList, string idfile) // Recibe la lista de personas y el codigo cargado a la persona
        {
            File file = new File();
            file.IdFile = idfile; // el codigo de la persona ingresado sera el codigo del legajo.
            Console.WriteLine("Ingrese el codigo de la persona");
            string code = Console.ReadLine();
            file.Person = personList.Find(p => code.Equals(p.CodePerson)); // Recorre la lista y encuentra una persona donde la condicion de que el codigo y el Id sean iguales, para luego mostrarlo.
            // la clase file tiene como atributo a Person (persona)
            file.toString();//Lo mostramos.
            Console.WriteLine("Se ha generado con éxito el numero de Legajo");
            Console.WriteLine(" ");
            return file;
        }
        static int generateId() // Generar el Id del legajo.
        {
            int code;
            Random random = new Random();
            code = random.Next(1, 99);
            return code;
        }
        static DefinitivePerson createDefinitivePerson(Person person, File file)
        {
            DefinitivePerson person1 = new DefinitivePerson();

            person1.Du = person.Du;
            person1.Gender = person.Gender;
            person1.LastName = person.LastName;
            person1.Name = person.Name;
            person1.Age = person.Age;
            person1.DateBirth = person.DateBirth;
            person1.CodePerson = person.CodePerson;
            person1.FileDef = file.IdFile;

            return person1;
        }

        static void modificateDefPerson(int opcionCampo, DefinitivePerson p)
        {
            if (opcionCampo == 1)
            {
                Console.WriteLine("Escriba el nuevo DU respetando las reglas de validación");
                int newDU = Convert.ToInt32(Console.ReadLine());
                p.Du = newDU;
            }

            if (opcionCampo == 2)
            {
                Console.WriteLine("Escriba la nueva opcion de genero");
                string newGender = Console.ReadLine();
                p.Gender = newGender;
            }

            if (opcionCampo == 3)
            {
                Console.WriteLine("Escriba el nuevo apellido");
                string newLastName = Console.ReadLine();
                p.LastName = newLastName;
            }

            if (opcionCampo == 4)
            {
                Console.WriteLine("Escriba el nuevo Nombre");
                string newName = Console.ReadLine();
                p.Name = newName;
            }

            if (opcionCampo == 5)
            {
                Console.WriteLine("Escriba la nueva Edad respetando las reglas de validación");
                int newAge = Convert.ToInt32(Console.ReadLine());
                p.Age = newAge;
            }

            if (opcionCampo == 6)
            {
                Console.WriteLine("Escriba la nueva Fecha de Nacimiento");
                string newDateBirth = Console.ReadLine();
                p.DateBirth = newDateBirth;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Su modificación se ha realizado con exito");
            Console.WriteLine(" ");
        }

        static void showAllList(List<DefinitivePerson> defList, List<Person> personList, List<File> fileList)
        {
            do
            {
                Console.WriteLine("Elija la lista que desea ver: ");
                Console.WriteLine("1- Lista de Empleados");
                Console.WriteLine("2- Lista de Personas");
                Console.WriteLine("3- Lista de Legajos");
                int opcionList = Convert.ToInt32(Console.ReadLine());

                switch (opcionList)
                {
                    case 1:
                        Console.WriteLine("Lista de Empleados");
                        Console.WriteLine(" ");
                        foreach (DefinitivePerson d in defList)
                        {
                            Console.WriteLine(d.FileDef + " " + d.Du + " " + d.LastName + ", " + d.Name + " " + d.CodePerson);
                        }
                        Console.WriteLine("----------------------------------------");
                        break;

                    case 2:
                        Console.WriteLine(" ");
                        Console.WriteLine("Lista de Personas");
                        Console.WriteLine(" ");
                        foreach (Person p in personList)
                        {
                            Console.WriteLine(p.CodePerson + " " + p.LastName + ", " + p.Name);
                        }
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine(" ");
                        break;

                    case 3:
                        Console.WriteLine("Lista de Legajos");
                        Console.WriteLine(" ");
                        foreach (File f in fileList)
                        {
                            Console.WriteLine(f.IdFile + " " + f.Person.LastName + ", " + f.Person.Name);
                        }
                        Console.WriteLine(" ");
                        break;
                }

                Console.WriteLine(" ");
                Console.WriteLine("Quiere ver otra lista: s / n");
                listDesition = Console.ReadLine();

            } while (listDesition == "s");
        }

        static void showPersonListSave(List<DefinitivePerson> saveList)
        {
            Console.WriteLine("Lista de datos guardados");
            Console.WriteLine(" ");
            foreach (DefinitivePerson d in saveList)
            {
                Console.WriteLine(d.FileDef + " " + d.Du + " " + d.LastName + ", " + d.Name + " " + d.CodePerson);
            }
            Console.WriteLine(" ");

        }

        public void showMenu()
        {
            List<Person> personList = new List<Person>();
            List<File> fileList = new List<File>();
            List<DefinitivePerson> defList = new List<DefinitivePerson>();
            Statistics st = new Statistics();

            do
            {
                do
                {
                    Console.WriteLine("Elija una opción para operar");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("0.- Agregar empleado");
                    Console.WriteLine("1.- Eliminar Legajo");
                    Console.WriteLine("2.- Busqueda / Modificación del Empleado");
                    Console.WriteLine("3.- Lista de Empleados");
                    Console.WriteLine("4.- Estadisticas básicas");
                    Console.WriteLine("5.- Guardar Cambios / Cargar Datos");
                    Console.WriteLine("6.- Salir");
                    Console.WriteLine("----------------------------------");

                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion < 0 || opcion > 6)
                    {
                        Console.WriteLine("Ingrese una opcion valida entre 0 y 6");
                    }

                } while (opcion < 0 || opcion > 6);

                switch (opcion)
                {
                    case 0:

                        // Se crea la persona y se agrega a la lista de personas.
                        Person person = createPerson();
                        personList.Add(person);

                        // Se crea un legajo y se agrega a la lista de legajos.
                        File file = createFile(personList, generateId().ToString("PG000/00"));
                        fileList.Add(file);

                        // Se crea una persona Definitiva y se le agrega la persona y su respectivo ID Legajo.
                        DefinitivePerson person10 = createDefinitivePerson(person, file);
                        defList.Add(person10);

                        break;

                    case 1:

                        Console.WriteLine("Ingrese el codigo del empleado que desea eliminar de forma permanente");
                        string codeRemoved = Console.ReadLine();
                        defList.RemoveAll(r => r.CodePerson == codeRemoved);
                        personList.RemoveAll(r => r.CodePerson == codeRemoved);
                        fileList.RemoveAll(r => r.Person.CodePerson == codeRemoved);
                        Console.WriteLine("El empleado se ha eliminado con exito");
                        Console.WriteLine(" ");
                        break;

                    case 2:

                        Console.WriteLine("Escriba de forma exacta el legajo que desea buscar");
                        string fileSearch = Console.ReadLine();
                        DefinitivePerson personSearch = defList.Find(r => r.FileDef == fileSearch);
                        personSearch.ShowDefPerson();

                        Console.WriteLine("Desea Modificarlo? s / n");
                        string opcionMod = Console.ReadLine();
                        if (opcionMod == "s")
                        {
                            Console.WriteLine("Que desea modificar del legajo {0}? Se modificara solo el campo elejido, no el codigo del legajo", personSearch.FileDef);
                            Console.WriteLine("1- DU");
                            Console.WriteLine("2- Sexo");
                            Console.WriteLine("3- Apellido");
                            Console.WriteLine("4- nombre");
                            Console.WriteLine("5- Edad");
                            Console.WriteLine("6- FechaDeNacimiento");

                            int opcionCampo = Convert.ToInt32(Console.ReadLine());
                            switch (opcionCampo)
                            {
                                case 1:
                                    modificateDefPerson(opcionCampo, personSearch);
                                    break;
                                case 2:
                                    modificateDefPerson(opcionCampo, personSearch);
                                    break;
                                case 3:
                                    modificateDefPerson(opcionCampo, personSearch);
                                    break;
                                case 4:
                                    modificateDefPerson(opcionCampo, personSearch);
                                    break;
                                case 5:
                                    modificateDefPerson(opcionCampo, personSearch);
                                    break;
                                case 6:
                                    modificateDefPerson(opcionCampo, personSearch);
                                    break;
                            }
                        }
                        break;

                    case 3:

                        showAllList(defList, personList, fileList);
                        break;

                    case 4:

                        st.showStatistics(defList);
                        break;

                    case 5:

                        Console.WriteLine("1.- Guardar los cambios en sistema");
                        Console.WriteLine("2.- Datos Cargados");
                        int opcionSave = Convert.ToInt32(Console.ReadLine());

                        switch (opcionSave)
                        {
                            case 1:

                                using (Stream fs1 = new FileStream(@"C:/Users/User/Desktop/Kripta/Proyecto1/Proyecto1/DefinitivePerson.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                                {
                                    //Ponemelo en un formato xml de tipo lista DefinitivePerson.
                                    XmlSerializer serializer11 = new XmlSerializer(typeof(List<DefinitivePerson>));
                                    serializer11.Serialize(fs1, defList); // Guardalo
                                    fs1.Close();
                                }

                                using (Stream fs2 = new FileStream(@"C:/Users/User/Desktop/Kripta/Proyecto1/Proyecto1/Person.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                                {
                                    XmlSerializer serializer12 = new XmlSerializer(typeof(List<Person>));
                                    serializer12.Serialize(fs2, personList); // Guardalo
                                    fs2.Close();
                                }

                                using (Stream fs3 = new FileStream(@"C:/Users/User/Desktop/Kripta/Proyecto1/Proyecto1/File.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                                {
                                    XmlSerializer serializer13 = new XmlSerializer(typeof(List<File>));
                                    serializer13.Serialize(fs3, fileList); // Guardalo
                                    fs3.Close();
                                }

                                Console.WriteLine(" ");
                                Console.WriteLine("Los Legajos se han guardado con exito");
                                Console.WriteLine(" ");
                                break;

                            case 2:

                                XmlSerializer serializer21 = new XmlSerializer(typeof(List<DefinitivePerson>));
                                using (Stream fs21 = new FileStream("C:/Users/User/Desktop/Kripta/Proyecto1/Proyecto1/DefinitivePerson.txt", FileMode.Open, FileAccess.Read, FileShare.None))
                                {
                                    //Mete lo recuperado de nuevo en la lista.
                                    defList = (List<DefinitivePerson>)serializer21.Deserialize(fs21);
                                    fs21.Close();
                                }

                                XmlSerializer serializer22 = new XmlSerializer(typeof(List<Person>));
                                using (Stream fs22 = new FileStream("C:/Users/User/Desktop/Kripta/Proyecto1/Proyecto1/Person.txt", FileMode.Open, FileAccess.Read, FileShare.None))
                                {
                                    personList = (List<Person>)serializer22.Deserialize(fs22);
                                    fs22.Close();
                                }

                                XmlSerializer serializer23 = new XmlSerializer(typeof(List<File>));
                                using (Stream fs23 = new FileStream("C:/Users/User/Desktop/Kripta/Proyecto1/Proyecto1/File.txt", FileMode.Open, FileAccess.Read, FileShare.None))
                                {
                                    fileList = (List<File>)serializer23.Deserialize(fs23);
                                    fs23.Close();
                                }
                                showPersonListSave(defList);
                                break;
                        }
                        break;
                }

            } while (opcion != 6);

            Console.WriteLine("Muchas gracias Vuelva Pronto");
        }
    }
}