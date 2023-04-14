namespace Gerador_de_senhas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxNumeros = new CheckBox();
            trackBarQuantidade = new TrackBar();
            label1 = new Label();
            groupPropriedades = new GroupBox();
            valorQuantidade = new Label();
            checkBoxEspecial = new CheckBox();
            botaoGerar = new Button();
            textBoxSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trackBarQuantidade).BeginInit();
            groupPropriedades.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxNumeros
            // 
            checkBoxNumeros.AutoSize = true;
            checkBoxNumeros.Location = new Point(6, 22);
            checkBoxNumeros.Name = "checkBoxNumeros";
            checkBoxNumeros.Size = new Size(117, 19);
            checkBoxNumeros.TabIndex = 0;
            checkBoxNumeros.Text = "Apenas Números";
            checkBoxNumeros.UseVisualStyleBackColor = true;
            // 
            // trackBarQuantidade
            // 
            trackBarQuantidade.Location = new Point(6, 94);
            trackBarQuantidade.Maximum = 32;
            trackBarQuantidade.Minimum = 6;
            trackBarQuantidade.Name = "trackBarQuantidade";
            trackBarQuantidade.Size = new Size(180, 45);
            trackBarQuantidade.TabIndex = 1;
            trackBarQuantidade.Value = 6;
            trackBarQuantidade.Scroll += trackBarQuantidade_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 2;
            label1.Text = "quantidade: ";
            // 
            // groupPropriedades
            // 
            groupPropriedades.Controls.Add(valorQuantidade);
            groupPropriedades.Controls.Add(checkBoxEspecial);
            groupPropriedades.Controls.Add(checkBoxNumeros);
            groupPropriedades.Controls.Add(trackBarQuantidade);
            groupPropriedades.Controls.Add(label1);
            groupPropriedades.Location = new Point(12, 12);
            groupPropriedades.Name = "groupPropriedades";
            groupPropriedades.Size = new Size(261, 145);
            groupPropriedades.TabIndex = 3;
            groupPropriedades.TabStop = false;
            groupPropriedades.Text = "propriedades";
            // 
            // valorQuantidade
            // 
            valorQuantidade.AutoSize = true;
            valorQuantidade.Location = new Point(192, 94);
            valorQuantidade.Name = "valorQuantidade";
            valorQuantidade.Size = new Size(13, 15);
            valorQuantidade.TabIndex = 4;
            valorQuantidade.Text = "6";
            // 
            // checkBoxEspecial
            // 
            checkBoxEspecial.AutoSize = true;
            checkBoxEspecial.Location = new Point(6, 47);
            checkBoxEspecial.Name = "checkBoxEspecial";
            checkBoxEspecial.Size = new Size(131, 19);
            checkBoxEspecial.TabIndex = 3;
            checkBoxEspecial.Text = "Caracteres especiais";
            checkBoxEspecial.UseVisualStyleBackColor = true;
            // 
            // botaoGerar
            // 
            botaoGerar.Location = new Point(12, 192);
            botaoGerar.Name = "botaoGerar";
            botaoGerar.Size = new Size(331, 35);
            botaoGerar.TabIndex = 4;
            botaoGerar.Text = "Gerar senha";
            botaoGerar.UseVisualStyleBackColor = true;
            botaoGerar.Click += botaoGerar_Click;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(12, 163);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(331, 23);
            textBoxSenha.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 237);
            Controls.Add(textBoxSenha);
            Controls.Add(botaoGerar);
            Controls.Add(groupPropriedades);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Gerador de senhas";
            ((System.ComponentModel.ISupportInitialize)trackBarQuantidade).EndInit();
            groupPropriedades.ResumeLayout(false);
            groupPropriedades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxNumeros;
        private TrackBar trackBarQuantidade;
        private Label label1;
        private GroupBox groupPropriedades;
        private CheckBox checkBoxEspecial;
        private Button botaoGerar;
        private TextBox textBoxSenha;
        private Label valorQuantidade;
    }
}