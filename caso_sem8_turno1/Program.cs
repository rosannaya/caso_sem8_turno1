using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso_sem8_turno1
{
    internal class Program
    {
        static int max = 100;
        static string[] nombres = new string[max];
        static double[] notas = new double[max];
        static int contador = 0;
        static public void Titulo()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Sistemas de notas");
            Console.WriteLine("*****************************");
        }
        static public void Registrar_estudiante()
        {
            Console.WriteLine("Registro de estudiante nuevo: ");
            if (contador >= max)
            {
                Console.WriteLine("Llegamos a  la capacidad máxima");
                return;
            }
            Console.Write("Ingresar nombres: ");
            string nombre = Console.ReadLine();
            double nota;
            while (true)
            {
                Console.Write("Ingresar nota: ");
                nota = double.Parse(Console.ReadLine());
                if (nota >= 0 && nota <= 20)
                {
                    break;
                }
                Console.WriteLine("Error: La nota debe ser [0-20]:");
            }
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
        }
        static public void Buscar_estudiante()
        {
            Console.WriteLine("******BUSCAR ESTUDIANTE*******");
            if (contador == 0)
            {
                Console.WriteLine("No hay estudiantes registrados");
                return ;
            }
            Console.Write("Ingresar nombre a buscar: ");
            string nom_buscar= Console.ReadLine().ToLower();
            bool encontrado = false;
            for(int i = 0; i < contador; i++)
            {
                if (nombres[i].ToLower() == nom_buscar)
                {
                    Console.WriteLine("Estudiante encontrado:");
                    Console.WriteLine(nombres[i] + "tiene " + notas[i]);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
                Console.WriteLine("Estudiante no encontrado...");
        }
        static public void Modificar_nota() {
            Console.WriteLine("**********MODIFICAR NOTA*********");
            if (contador == 0)
            {
                Console.WriteLine("No hay estudiantes registrados");
                return;
            }
            Console.Write("Ingresar nombre del estudiante: ");
            string nom_buscar=Console.ReadLine().ToLower();
            for(int i = 0; i < contador; i++)
            {
                if (nombres[i].ToLower() == nom_buscar)
                {
                    Console.WriteLine(nombres[i]+" tiene " + notas[i]);
                    double nueva_nota;
                    while (true)
                    {
                        Console.Write("Ingresar la nueva nota: ");
                        nueva_nota=double.Parse(Console.ReadLine());
                        if (nueva_nota>=0 && nueva_nota <= 20)
                        {
                            notas[i]=nueva_nota;
                            Console.WriteLine("Nota modificada correctamente");
                            return;
                        }
                        Console.WriteLine("Nota fuera de rango[0-20]");
                    }
                }
            }
            Console.WriteLine("Estudiante no encontrado...");
        }
        static public void Mostrar()
        {
            Console.WriteLine("*******LISTADO ORIGINAL********");
            if (contador == 0)
            {
                Console.WriteLine("No hay estudiantes registrados");
                return;
            }
            Console.WriteLine("\tNOMBRE \t\tNOTAS");
            for (int i = 0;i < contador; i++)
            {
             Console.WriteLine("\t" + nombres[i] + "\t\t" + notas[i]);
            }
        }
        static public void burbuja()
        {
            Console.WriteLine("******ORDENAMIENTO ASCENDENTE*******");
            double temp_nota;
            string temp_nombre;
            for(int i = 0; i < contador - 1; i++)
            {
                for(int j = 0; j < contador - 1 - i; j++)
                {
                    if (notas[j] > notas[j + 1])
                    {
                        temp_nota = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j+1]= temp_nota;

                        temp_nombre = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j+1] = temp_nombre;
                    }
                }
            }
        }
        static public void Seleccion_DESC()
        {

        }
        static public void nota_max_prom()
        {

        }
        static void Main(string[] args)
        {
            Titulo();
            int opc=0;
            while (opc !=7)
            {
                Console.WriteLine("*************************");
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("*************************");
                Console.WriteLine("[1]Registrar estudiante");
                Console.WriteLine("[2]Buscar estudiante");
                Console.WriteLine("[3]Modificar nota");
                Console.WriteLine("[4]Mostrar lista sin ordenar");
                Console.WriteLine("[5]Ordenar con Burbuja");
                Console.WriteLine("[6]Ordenar con Selección Desc");
                Console.WriteLine("[7]Salir");
                Console.Write("Ingresar opción: ");
                opc=int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Registrar_estudiante();
                        break;
                    case 2:
                        Buscar_estudiante();
                        break;
                    case 3:
                        Modificar_nota();
                        break;
                    case 4:
                        Mostrar();
                        break;
                    case 5:
                        burbuja();
                        break;
                    case 6:
                        Seleccion_DESC();
                        break;
                    case 7:
                        Console.WriteLine("Gracias por usar el sistema");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta..!!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
