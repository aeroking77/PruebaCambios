using Interfaces.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Metodos
{
    public interface IMetodosEscuela
    {
        void Guardar(Escuela escuela);
        void Editar(int indice);
        void Eliminar(int indice);
        Escuela Buscar(int indice);
        void MostrarTodo();

    }
}
