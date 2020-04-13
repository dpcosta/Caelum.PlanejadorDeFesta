namespace Caelum.PlanejadorDeFesta
{
    public class FestaNoturna
    {
        public FestaNoturna(int convidados, bool bebidasAlcoolicas, bool tematica)
        {
            this.QtdeConvidados = convidados;
            this.Tematica = tematica;
            this.BebidasAlcoolicas = bebidasAlcoolicas;
        }

        public int QtdeConvidados { get; }
        public bool Tematica { get; }
        public bool BebidasAlcoolicas { get; }

        public decimal CustoComida => QtdeConvidados * 25.0M;
        public decimal CustoBebida => BebidasAlcoolicas ? QtdeConvidados * 20.0M : QtdeConvidados * 5.0M;
        public decimal CustoTematica => Tematica ? (QtdeConvidados * 15.0M) + 50.0M : (QtdeConvidados * 7.5M) + 30.0M;
        public decimal CustoTotal => CustoComida + CustoBebida + CustoTematica;
    }
}