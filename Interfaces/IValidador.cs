using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interfaces
{
    public interface IValidador<T>
    {
        bool Validar(T entidade, out string erro);
    }

}
