using Interfaces.Entidad;
using Interfaces.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Service
{
    public class AlumnoService:IMetodosAlumno
    {
        List<Alumno> listaAlumnos = new List<Alumno>();

        public void Guardar(Alumno alumno) 
        {
            bool bandera = false;
            foreach (Alumno a in listaAlumnos) 
            {
                if (a.Matricula == alumno.Matricula) 
                {
                    Console.WriteLine("El alumno no se agrego a la lista por que la matricula ya existe");
                    bandera = true;
                    break;
                }
                if (a.Nombre == alumno.Nombre && a.Apellido == alumno.Apellido) 
                {
                    Console.WriteLine("El alumno no se agrego a la lista por que su nombre ya existe");
                    bandera = true;
                    break;
                } 
            }
            if (bandera == false) 
            {
                listaAlumnos.Add(alumno);
                Console.WriteLine("El alumno ha sido agregado a la lista");
            }
        }

        public void Editar(int indice) 
        {
            int menuEditar;
            Console.WriteLine(listaAlumnos[indice]);
            Alumno alumno_aux = listaAlumnos[indice];
            do 
            {
                Console.WriteLine("\nMenu editar Alumno");
                Console.WriteLine("1.-Nombre");
                Console.WriteLine("2.-Apellido");
                Console.WriteLine("3.-Edad");
                Console.WriteLine("4.-Genero");
                Console.WriteLine("5.-Promedio");
                Console.WriteLine("6.-Salir del menu editar");
                menuEditar = int.Parse(Console.ReadLine());
                switch (menuEditar) 
                {
                    case 1:
                        Console.WriteLine("Ingresa el nuevo nombre del alumno");
                        string nombre = Console.ReadLine();
                        alumno_aux.Nombre = nombre;
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el apellido nuevo del Alumno");
                        string apellido = Console.ReadLine();
                        alumno_aux.Apellido = apellido;
                        break;
                    case 3:
                        Console.WriteLine("Ingresa la edad nueva del Alumno");
                        int edad = int.Parse(Console.ReadLine());
                        alumno_aux.setEdad(edad);
                        break;
                    case 4:
                        Console.WriteLine("Ingresa el genero nuevo del Alumno");
                        string genero = Console.ReadLine();
                        alumno_aux.Genero = genero;
                        break;
                    case 5:
                        Console.WriteLine("Ingresa el promedio nuevo");
                        decimal promedio = decimal.Parse(Console.ReadLine());
                        alumno_aux.setPromedio(promedio);
                        break;
                    case 6:
                        Console.WriteLine("Regresando al menu Alumno\n");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida intenta de nuevo");
                        break;
                }
                listaAlumnos[indice] = alumno_aux;
            }
            while (menuEditar != 6);
        }

        public void Eliminar(int indice)
        {
            if (indice >= listaAlumnos.Count())
            {
                Console.WriteLine("El alumno que tratas de eliminar no existe");
            }
            else 
            {
                Alumno alumno = listaAlumnos[indice];
                listaAlumnos.RemoveAt(indice);
                Console.WriteLine("El alumno ha sido eliminado de la lista\n"+alumno);
            }

        }

        public Alumno Buscar(int indice) 
        {
            if (indice >= listaAlumnos.Count())
            {
                return null;
            }
            else 
            {
                Alumno alumno = listaAlumnos[indice];
                return alumno;
            }
        }

        public void MostrarTodo() 
        {
            if (listaAlumnos.Count() == 0)
            {
                Console.WriteLine("No existen Alumnos en la lista");
            }
            else 
            {
                foreach (Alumno a in listaAlumnos) 
                {
                    Console.WriteLine(a);
                }
            }
        }

        public void Listar() 
        {
            if (listaAlumnos.Count() == 0)
            {
                Console.WriteLine("No existen Alumnos que listar");
            }
            else 
            {
                foreach (Alumno a in listaAlumnos) 
                {
                    Console.WriteLine(listaAlumnos.IndexOf(a)+"=>"+a);
                }
            }
        }

        public void BuscarPorEdad(int edad)
        {
            bool bandera = true;
            foreach (Alumno a in listaAlumnos) 
            {
                if (edad == a.Edad) 
                {
                    Console.WriteLine(a);
                    bandera = false ;
                }
            }
            if (bandera == false) 
            {
                Console.WriteLine("No hay ningun alumno con esas edad");
            }
        }
    }
}
