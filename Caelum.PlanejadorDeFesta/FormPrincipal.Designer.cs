namespace Caelum.PlanejadorDeFesta
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkTematica = new System.Windows.Forms.CheckBox();
            this.chkBebidas = new System.Windows.Forms.CheckBox();
            this.btnCalcFestaNoturna = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textoBolo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numConvidadosAniversario = new System.Windows.Forms.NumericUpDown();
            this.chkTemaAniversario = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConvidadosAniversario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkTematica);
            this.tabPage1.Controls.Add(this.chkBebidas);
            this.tabPage1.Controls.Add(this.btnCalcFestaNoturna);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(236, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Noturna";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkTematica
            // 
            this.chkTematica.AutoSize = true;
            this.chkTematica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTematica.Location = new System.Drawing.Point(25, 82);
            this.chkTematica.Name = "chkTematica";
            this.chkTematica.Size = new System.Drawing.Size(92, 20);
            this.chkTematica.TabIndex = 4;
            this.chkTematica.Text = "Temática";
            this.chkTematica.UseVisualStyleBackColor = true;
            // 
            // chkBebidas
            // 
            this.chkBebidas.AutoSize = true;
            this.chkBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBebidas.Location = new System.Drawing.Point(25, 118);
            this.chkBebidas.Name = "chkBebidas";
            this.chkBebidas.Size = new System.Drawing.Size(161, 20);
            this.chkBebidas.TabIndex = 3;
            this.chkBebidas.Text = "Bebidas alcoólicas";
            this.chkBebidas.UseVisualStyleBackColor = true;
            // 
            // btnCalcFestaNoturna
            // 
            this.btnCalcFestaNoturna.Location = new System.Drawing.Point(25, 189);
            this.btnCalcFestaNoturna.Name = "btnCalcFestaNoturna";
            this.btnCalcFestaNoturna.Size = new System.Drawing.Size(189, 50);
            this.btnCalcFestaNoturna.TabIndex = 2;
            this.btnCalcFestaNoturna.Text = "Calcular";
            this.btnCalcFestaNoturna.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(25, 44);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(137, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pessoas Convidadas:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textoBolo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numConvidadosAniversario);
            this.tabPage2.Controls.Add(this.chkTemaAniversario);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(236, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aniversário";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textoBolo
            // 
            this.textoBolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textoBolo.Location = new System.Drawing.Point(25, 137);
            this.textoBolo.MaxLength = 16;
            this.textoBolo.Name = "textoBolo";
            this.textoBolo.Size = new System.Drawing.Size(189, 22);
            this.textoBolo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Texto do Bolo";
            // 
            // numConvidadosAniversario
            // 
            this.numConvidadosAniversario.Location = new System.Drawing.Point(25, 44);
            this.numConvidadosAniversario.Margin = new System.Windows.Forms.Padding(4);
            this.numConvidadosAniversario.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numConvidadosAniversario.Name = "numConvidadosAniversario";
            this.numConvidadosAniversario.Size = new System.Drawing.Size(137, 22);
            this.numConvidadosAniversario.TabIndex = 9;
            this.numConvidadosAniversario.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // chkTemaAniversario
            // 
            this.chkTemaAniversario.AutoSize = true;
            this.chkTemaAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTemaAniversario.Location = new System.Drawing.Point(25, 82);
            this.chkTemaAniversario.Name = "chkTemaAniversario";
            this.chkTemaAniversario.Size = new System.Drawing.Size(92, 20);
            this.chkTemaAniversario.TabIndex = 8;
            this.chkTemaAniversario.Text = "Temática";
            this.chkTemaAniversario.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pessoas Convidadas:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 288);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planejador de Festas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConvidadosAniversario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkTematica;
        private System.Windows.Forms.CheckBox chkBebidas;
        private System.Windows.Forms.Button btnCalcFestaNoturna;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoBolo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numConvidadosAniversario;
        private System.Windows.Forms.CheckBox chkTemaAniversario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

