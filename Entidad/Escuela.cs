using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidad
{
    public class Escuela
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Nivel { get; set; }

        public string Ciudad {  get; set; }
        public int Capacidad;
        public List<Alumno> Alumnos { get; set; }

        public Escuela() 
        {
        }

        public Escuela(int id, string nombre, string nivel, string ciudad, int capacidad, List<Alumno> alumnos)
        {
            Id = id;
            Nombre = nombre;
            Nivel = nivel;
            Ciudad = ciudad;
            Capacidad = capacidad;
            Alumnos = alumnos;
        }

        public override string ToString()
        {
            return $"Escuela=> id:{Id}, Nombre:{Nombre}, Nivel:{Nivel}, Ciudad:{Ciudad}, Capacidad:{Capacidad}, Alumnos:\n {ObtenerAlumnos()}";
        }

        public void setCapacidad(int capacidad) 
        {
            if (capacidad < 0) 
            {
                capacidad = 0;
            }
            Capacidad = capacidad;
        }

        public int getCapacidad() 
        { 
            return Capacidad; 
        }
        
        public string ObtenerAlumnos() 
        {
            string alumnos ="";
            foreach (Alumno a in Alumnos) 
            {
                alumnos += a+"\n";
            }
            return alumnos;
        }
    }
}
