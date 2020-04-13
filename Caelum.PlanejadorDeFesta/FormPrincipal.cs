using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caelum.PlanejadorDeFesta
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcFestaNoturna_Click(object sender, EventArgs e)
        {
            int qtdeConvidados = Convert.ToInt32(numConvidadosFestaNoturna.Value);
            bool alcool = chkBebidas.Checked;
            bool tema = chkTematica.Checked;

            decimal custoComida = qtdeConvidados * 25.0M;
            decimal custoBebida = alcool ? qtdeConvidados * 20.0M : qtdeConvidados * 5.0M;
            decimal custoTematica = tema ? (qtdeConvidados * 15.0M) + 50.0M : (qtdeConvidados * 7.5M) + 30.0M;
            decimal custoTotal = custoComida + custoBebida + custoTematica;

            string mensagem = $@"
                O custo total da festa noturna é R$ {custoTotal:0.00}
                Comidas: {custoComida:0.00}
                Bebidas: {custoBebida:0.00}
                Temática: {custoTematica:0.00}
            ";

            MessageBox.Show(mensagem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qtdeConvidados = Convert.ToInt32(numConvidadosAniversario.Value);
            string texto = textoBolo.Text;
            bool tema = chkTemaAniversario.Checked;

            decimal custoComida = qtdeConvidados * 25.0M;
            decimal custoBebida = qtdeConvidados * 5.0M;
            decimal custoTematica = tema ? (qtdeConvidados * 15.0M) + 50.0M : (qtdeConvidados * 7.5M) + 30.0M;
            decimal custoLetras = texto.Length * 0.25M;
            decimal custoBolo = qtdeConvidados >= 8 ? 75.0M + custoLetras : 40.0M + custoLetras;
            decimal custoTotal = custoComida + custoBebida + custoTematica + custoBolo;

            string mensagem = $@"
                O custo total da festa de aniversário R$ {custoTotal:0.00}
                Comidas: {custoComida:0.00}
                Bebidas: {custoBebida:0.00}
                Temática: {custoTematica:0.00}
                Bolo: {custoBolo:0.00}
            ";

            MessageBox.Show(mensagem);
        }
    }
}
