using Interfaces.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Metodos
{
    //Una interfaz es un conjunto de metodos vacios los cuales pueden se implementados por
    //cualquier clase, pero la clase que la implemente tiene la obligacion de darle funcionabilidad a esos metodos
    public interface IMetodosAlumno
    {
        void Guardar(Alumno alumno);
        void Editar(int indice);
        void Eliminar(int indice);
        Alumno Buscar(int indice);
        void MostrarTodo();
    }
}
