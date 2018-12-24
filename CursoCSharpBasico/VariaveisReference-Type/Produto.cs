using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisReferenceType
{
    public class Produto
    {
        public int Quantidade { get; private set; }
        public void AlteraQuantidade(int valor)
        {
            this.Quantidade = valor;
        }
    }
}
