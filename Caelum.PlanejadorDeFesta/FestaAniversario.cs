using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.PlanejadorDeFesta
{
    public class FestaAniversario
    {

        public FestaAniversario(int qtde, string texto, bool tema)
        {
            QtdeConvidados = qtde;
            TextoBolo = texto;
            Tematica = tema;
        }

        public int QtdeConvidados { get;}
        public string TextoBolo { get; }
        public bool Tematica { get; }

        public decimal CustoBolo
        {
            get
            {
                decimal custoLetras = TextoBolo.Length * 0.25M;
                return QtdeConvidados >= 8 ? 75.0M + custoLetras : 40.0M + custoLetras;
            }
        }

        public decimal CustoComida => QtdeConvidados * 25.0M;
        public decimal CustoBebida => QtdeConvidados * 5.0M;
        public decimal CustoTematica => Tematica ? (QtdeConvidados * 15.0M) + 50.0M : (QtdeConvidados * 7.5M) + 30.0M;
        public decimal CustoTotal => CustoComida + CustoBebida + CustoTematica + CustoBolo;
    }
}
