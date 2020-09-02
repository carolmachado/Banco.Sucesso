using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public interface IPessoa: INome
    {
       

        string Documento { get; set; }

        DateTime DataDeNascimento { get; set; }

        string Telefone { get; set; }

        string Celular { get; set; }
    }
}
