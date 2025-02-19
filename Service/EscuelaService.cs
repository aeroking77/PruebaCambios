using Interfaces.Entidad;
using Interfaces.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Service
{
    internal class EscuelaService:IMetodosEscuela
    {
        List<Escuela>listaEscuela = new List<Escuela>();

        public void Guardar(Escuela escuela) 
        {
            bool bandera = false;
            foreach (Escuela a in listaEscuela) 
            {
                if (a.Id == escuela.Id) 
                {
                    Console.WriteLine("Que la escuela no se agrego por que si id ya existe");
                    bandera = true;
                    break;
                }
                if (a.Nombre == escuela.Nombre) 
                {
                    Console.WriteLine("Que la escuela no se agrego por que el nombre ya existe");
                    bandera = true;
                    break;
                }
            }
            if (bandera == false) 
            {
                listaEscuela.Add(escuela);
                Console.WriteLine("La escuela ha sido agregada a la lista");
            }
        }

        public void Editar(int indice) 
        {
            Escuela escuela = listaEscuela[indice];
            Console.WriteLine(escuela);
            int menuEditar;
            do
            {
                Console.WriteLine("\nMenu editar");
                Console.WriteLine("1.-Nombre");
                Console.WriteLine("2.-Nivel");
                Console.WriteLine("3.-Capacidad");
                Console.WriteLine("4.-Ciudad");
                Console.WriteLine("5.-Salir del emnu editar");
                menuEditar = int.Parse(Console.ReadLine());
                switch (menuEditar) 
                {
                    case 1:
                        Console.WriteLine("Ingresa el nombre nuevo de la escuela");
                        string nombre = Console.ReadLine();
                        escuela.Nombre = nombre;
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el nivel nuevo");
                        string nivel = Console.ReadLine();
                        escuela.Nivel = nivel;
                        break;
                    case 3:
                        Console.WriteLine("Ingresa la capacidad nueva");
                        int capacidad = int.Parse(Console.ReadLine());
                        escuela.setCapacidad(capacidad);
                        break;
                    case 4:
                        Console.WriteLine("Ingresa la ciudad nueva de la escuela");
                        string ciudad = Console.ReadLine();
                        escuela.Ciudad = ciudad;
                        break;
                    case 5:
                        Console.WriteLine("Regresando al menu escuela");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida intenta de nuevo");
                        break;
                }
                listaEscuela[indice] = escuela;
            }
            while (menuEditar != 5);
        }

        public void Eliminar(int indice) 
        {
            if (indice < listaEscuela.Count())
            {
                Escuela escuela = listaEscuela[indice];
                listaEscuela.RemoveAt(indice);
                Console.WriteLine("La escuela ha sido eliminada de la lista\n"+escuela);
            }
            else 
            {
                Console.WriteLine("La escuela que tratas de eliminar no existe");
            }
        }

        public Escuela Buscar(int indice) 
        {
            if (indice >= listaEscuela.Count())
            {
                return null;
            }
            else 
            {
                Escuela escuela = listaEscuela[indice];
                return escuela;
            }
        }

        public void MostrarTodo()
        {
            if (listaEscuela.Count() == 0)
            {
                Console.WriteLine("No existen escuelas en la lista");
            }
            else 
            {
                foreach (Escuela e in listaEscuela) 
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void AsignarAlumno(Alumno alumno) 
        {
            Console.WriteLine("Ingresa el indice de la escuela");
            int indice = int.Parse(Console.ReadLine());
            Escuela escuela = Buscar(indice);
            if (escuela == null)
            {
                Console.WriteLine("La escuela que tratas de asignar al alumno no existe");
            }
            else 
            {
                escuela.Alumnos.Add(alumno);
                listaEscuela[indice] = escuela;
            }

        }
    }
}
