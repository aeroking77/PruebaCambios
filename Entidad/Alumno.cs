using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entidad
{
    public class Alumno
    {
        public int Matricula {  get; set; }
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public int Edad;
        public string Genero { get; set; }
        public decimal Promedio;

        public Alumno() { }

        public Alumno(int matricula, string nombre, string apellido, int edad, string genero, decimal promedio)
        {
            Matricula = matricula;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Genero = genero;
            Promedio = promedio;
        }

        public override string ToString()
        {
            return $"Alumno=> Matricula:{Matricula}, Nombre:{Nombre}, Apellido:{Apellido}, Edad:{Edad}, Genero:{Genero},Promedio:{Promedio}";
        }

        public int getEdad() 
        {
            return Edad;
        }

        public void setEdad(int edad) 
        {
            if (edad < 0) 
            {
                edad = 0;
            }
            Edad = edad;
        }

        public decimal getPromedio() 
        {
            return Promedio;
        }

        public void setPromedio(decimal promedio)
        {
            if (promedio < 0) 
            {
                promedio = 0;
            }
            Promedio = promedio;
        }
    }
}
