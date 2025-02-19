
using Interfaces.Entidad;
using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atributos de la clase Alumno
            int matricula;
            string nombre;
            string apellido;
            int edad;
            string genero;
            decimal promedio;

            //Atributos de la clase Escuela
            int id;
            string nivel;
            string ciudad;
            int capacidad;

            AlumnoService alumnoService = new AlumnoService();
            EscuelaService escuelaService = new EscuelaService();
            Escuela escuela = new Escuela();
            Alumno alumno = new Alumno();
            int indice, menu, menuEscuela, menuAlumnos;
            do 
            {
                Console.WriteLine("\nMenu Principal");
                Console.WriteLine("1.-Alumno");
                Console.WriteLine("2.-Escuela");
                Console.WriteLine("3.-Salir");
                menu = int.Parse(Console.ReadLine());
                switch (menu) 
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("\nMenu de Alumnos");
                            Console.WriteLine("1.-Alta");
                            Console.WriteLine("2.-Editar");
                            Console.WriteLine("3.-Buscar");
                            Console.WriteLine("4.-Eliminar");
                            Console.WriteLine("5.-Mostrar a todos los Alumnos");
                            Console.WriteLine("6.-Listar Alumnos por indice");
                            Console.WriteLine("7.-Regresar al menu principal");
                            Console.WriteLine("8.-Buscar a los alumnos por una edad");
                            menuAlumnos = int.Parse(Console.ReadLine());
                            switch (menuAlumnos) 
                            {
                                case 1:
                                    Console.WriteLine("Ingresa la matricula del alumno");
                                    matricula = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingresa el nombre del Alumno");
                                    nombre = Console.ReadLine();

                                    Console.WriteLine("Ingresa el apellido del alumno");
                                    apellido = Console.ReadLine();

                                    Console.WriteLine("Ingresa la edad del alumno");
                                    edad = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingresa el genero del Alumno");
                                    genero = Console.ReadLine();

                                    Console.WriteLine("Ingresa el promedio del alumno");
                                    promedio = decimal.Parse(Console.ReadLine());

                                    alumno = new Alumno(matricula,nombre,apellido,edad,genero,promedio);
                                    alumnoService.Guardar(alumno);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingresa el indice del Alumno a editar");
                                    indice = int.Parse(Console.ReadLine());
                                    alumno = alumnoService.Buscar(indice);
                                    if (alumno == null)
                                    {
                                        Console.WriteLine("El alumno que tratas de editar no existe");
                                    }
                                    else 
                                    {
                                        alumnoService.Editar(indice);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Ingresar el indice del Alumno a buscar");
                                    indice = int.Parse(Console.ReadLine());
                                    alumno = alumnoService.Buscar(indice);
                                    if (alumno == null)
                                    {
                                        Console.WriteLine("El alumno que tratas de buscar no existe");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("El alumno ha sido encontrado\n"+alumno);
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Ingrese el indice del alumno a eliminar");
                                    indice = int.Parse(Console.ReadLine());
                                    alumnoService.Eliminar(indice);
                                    break;
                                case 5:
                                    alumnoService.MostrarTodo();
                                    break;
                                case 6:
                                    alumnoService.Listar();
                                    break;
                                case 7:
                                    Console.WriteLine("Regresando al menu principal");
                                    break;
                                    case 8:
                                    Console.WriteLine("Ingresa la edad para buscar a los alumnos");
                                    edad = int.Parse(Console.ReadLine());
                                    alumnoService.BuscarPorEdad(edad);
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida inteta de nuevo");
                                    break;
                            }
                        } while (menuAlumnos != 7);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("\nMenu de Escuelas");
                            Console.WriteLine("1.-Alta");
                            Console.WriteLine("2.-Editar");
                            Console.WriteLine("3.-Buscar");
                            Console.WriteLine("4.-Eliminar");
                            Console.WriteLine("5.-Mostrar a todos los Alumnos");
                            Console.WriteLine("6.-Listar Alumnos por indice");
                            Console.WriteLine("7.-Regresar al menu principal");
                            Console.WriteLine("8.-Asignar Alumno");
                            Console.WriteLine("9.-Mostrar Alumnos de una escuela");
                            menuAlumnos = int.Parse(Console.ReadLine());
                            switch (menuAlumnos)
                            {
                                case 1:
                                    Console.WriteLine("Ingresa el id de la escuela");
                                    id = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingresa el nombre de la escuela");
                                    nombre = Console.ReadLine();

                                    Console.WriteLine("Ingresa el nivel");
                                    nivel = Console.ReadLine();

                                    Console.WriteLine("Ingresa la ciudad");
                                    ciudad = Console.ReadLine();

                                    Console.WriteLine("Ingresa la capacidad de la escuela");
                                    capacidad = int.Parse(Console.ReadLine());

                                    escuela = new Escuela(id, nombre, nivel, ciudad, capacidad, new List<Alumno>());
                                    escuelaService.Guardar(escuela);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingresa el indice de la escuela a editar");
                                    indice = int.Parse(Console.ReadLine());
                                    escuela = escuelaService.Buscar(indice);
                                    if (escuela == null)
                                    {
                                        Console.WriteLine("La escuela que tratas de editar no existe");
                                    }
                                    else
                                    {
                                        escuelaService.Editar(indice);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Ingresar el indice el indice de la escuela a buscar");
                                    indice = int.Parse(Console.ReadLine());
                                    escuela = escuelaService.Buscar(indice);
                                    if (escuela == null)
                                    {
                                        Console.WriteLine("La escuela que tratas de buscar no existe");
                                    }
                                    else
                                    {
                                        Console.WriteLine("La escuela ha sido encontrado\n" + escuela);
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Ingresa el indice de la escuela a eliminar");
                                    indice = int.Parse(Console.ReadLine());
                                    escuelaService.Eliminar(indice);
                                    break;
                                case 5:
                                    escuelaService.MostrarTodo();
                                    break;
                                case 6:
                                    break;
                                case 7:
                                    Console.WriteLine("Regresando al menu principal");
                                    break;
                                case 8:
                                    Console.WriteLine("Ingresa el indice del Alumnos a asignar");
                                    indice = int.Parse(Console.ReadLine());
                                    alumno = alumnoService.Buscar(indice);
                                    if (alumno == null)
                                    {
                                        Console.WriteLine("El alumno que tratas de asignar no existe");
                                    }
                                    else 
                                    {
                                        escuelaService.AsignarAlumno(alumno);
                                    }
                                    break;
                                case 9:
                                    Console.WriteLine("Esta es una prueba");
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida inteta de nuevo");
                                    break;
                            }
                        } while (menuAlumnos != 7);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida intenta de nuevo");
                        break;
                }
            }while (menu != 3);


        }
    }
}
