using System;

namespace Banco
{
    public class Pessoa: IPessoa
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }
    }
}
