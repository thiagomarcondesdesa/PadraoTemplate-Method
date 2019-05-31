using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
     abstract class Auxiliar
    {
        public abstract void gravar(int id, DateTime data, Pessoa pessoa);
        
    }
}
