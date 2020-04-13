using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.PlanejadorDeFesta
{
    public class FestaAniversario : Festa
    {

        public FestaAniversario(int qtde, string texto, bool tema) : base(qtde, tema)
        {
            TextoBolo = texto;
        }

        public string TextoBolo { get; }

        public decimal CustoBolo
        {
            get
            {
                decimal custoLetras = TextoBolo.Length * 0.25M;
                return QtdeConvidados >= 8 ? 75.0M + custoLetras : 40.0M + custoLetras;
            }
        }

        public override decimal CustoTotal => CustoComida + CustoBebida + CustoTematica + CustoBolo;
    }
}
