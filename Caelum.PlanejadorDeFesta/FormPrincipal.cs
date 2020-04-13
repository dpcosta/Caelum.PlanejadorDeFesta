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
            FestaNoturna balada = new FestaNoturna(
                Convert.ToInt32(numConvidadosFestaNoturna.Value),
                chkBebidas.Checked,
                chkTematica.Checked
            );

            string mensagem = $@"
                O custo total da festa noturna é R$ {balada.CustoTotal:0.00}
                
                Comidas: {balada.CustoComida:0.00}
                Bebidas: {balada.CustoBebida:0.00}
                Temática: {balada.CustoTematica:0.00}
            ";

            MessageBox.Show(mensagem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FestaAniversario aniversario = new FestaAniversario(
                Convert.ToInt32(numConvidadosAniversario.Value), 
                textoBolo.Text, 
                chkTemaAniversario.Checked);

            string mensagem = $@"
                O custo total da festa de aniversário R$ {aniversario.CustoTotal:0.00}
                
                Comidas: {aniversario.CustoComida:0.00}
                Bebidas: {aniversario.CustoBebida:0.00}
                Temática: {aniversario.CustoTematica:0.00}
                Bolo: {aniversario.CustoBolo:0.00}
            ";

            MessageBox.Show(mensagem);
        }
    }
}
