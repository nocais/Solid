using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interfaces
{
    public interface IRepository<T>
    {
        void Inserir(T entidade);
        IEnumerable<T> Listar();
    }

}
