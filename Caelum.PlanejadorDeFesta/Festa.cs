using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.PlanejadorDeFesta
{
    public abstract class Festa
    {
        public Festa(int qtdeConvidados, bool tematica)
        {
            QtdeConvidados = qtdeConvidados;
            Tematica = tematica;
        }

        public int QtdeConvidados { get; }
        public bool Tematica { get; }
        public virtual decimal CustoComida => QtdeConvidados * 25.0M;
        public virtual decimal CustoBebida => QtdeConvidados * 5.0M;
        public virtual decimal CustoTematica => Tematica ? (QtdeConvidados * 15.0M) + 50.0M : (QtdeConvidados * 7.5M) + 30.0M;
        public virtual decimal CustoTotal => CustoComida + CustoBebida + CustoTematica;
    }
}
