// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

int tamano = 2;
String[] nombre = new string[tamano];
int[] edad = new int[tamano];
String[] cita = new string[tamano];
int opcion = 0;

menu();

void inicializar()
{
    nombre = Enumerable.Repeat("", tamano).ToArray<string>();
    cita = Enumerable.Repeat("", tamano).ToArray<string>();
    edad = Enumerable.Repeat(0, tamano).ToArray<int>();
    Console.WriteLine("Los arreglos han sido inicializados");
    Console.Read();
    Console.Clear();
}
void Agregar()
{
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine("Ingrese el nombre: "); nombre[i] = Console.ReadLine();
        Console.WriteLine("Ingrese la edad: "); edad[1] = int.Parse(Console.ReadLine());
    }
}

void Consulta()
{
    bool encontrado = false;
    Console.WriteLine("Digite el nombre a buscar");
    string nomb = Console.ReadLine(); //Maria
    for (int i = 0; i < nombre.Length; i++) //Maria
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.WriteLine($" La edad de {nomb} es{edad[i]}");
            encontrado = true;
        }
    }
    if (encontrado == false)
    {
        Console.WriteLine($" El cliente {nomb} no existe");
    }
}
void Reporte()
{
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Nombre       Edad");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("-------      ------");
        for (int i = 0; i < nombre.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nombre[i]} {edad[i]}");
        }
 }
void AsignarCita()
{
        Console.WriteLine("Digite el nombre del paciente para asignar la cita:");
        string nomb = Console.ReadLine();

        for (int i = 0; i < nombre.Length; i++)
        {
            if (nomb.Equals(nombre[i]))
            {
                Console.WriteLine("Ingrese la fecha y hora de la cita (por ejemplo, 2022-02-01 15:30):");
                cita[i] = Console.ReadLine();
                Console.WriteLine($"Cita asignada correctamente a {nomb}");
            }
        }

        Console.WriteLine($"El paciente {nomb} no fue encontrado. No se asignó ninguna cita.");
}
void menu()
{
        do
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("************ CONSULTORIO MEDICO ***********");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1- Inicializar arreglos");
        Console.WriteLine("2- Ingresar paciente");
        Console.WriteLine("3- Consultar paciente");
        Console.WriteLine("4- Reporte");
        Console.WriteLine("5- Asignar citas");
        Console.WriteLine("6- Salir");
        Console.WriteLine("Digite una opcion...");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
            {
                case 1: inicializar(); break;
                case 2: Agregar(); break;
                case 3: Consulta(); break;
                case 4: Reporte(); break;
                case 5: AsignarCita();break;
                default:
                    break;
            }

        } while (opcion != 6);
}

