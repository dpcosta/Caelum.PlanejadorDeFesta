namespace Caelum.PlanejadorDeFesta
{
    public class FestaNoturna : Festa
    {
        public FestaNoturna(int convidados, bool bebidasAlcoolicas, bool tematica) : base(convidados, tematica)
        {
            this.BebidasAlcoolicas = bebidasAlcoolicas;
        }

        public bool BebidasAlcoolicas { get; }

        public override decimal CustoBebida => BebidasAlcoolicas ? QtdeConvidados * 20.0M : QtdeConvidados * 5.0M;
    }
}