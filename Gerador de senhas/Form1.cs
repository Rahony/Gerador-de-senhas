using System.Text;

namespace Gerador_de_senhas
{
    public partial class Form1 : Form
    {
        const string caracteresNormais = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        const string caracteresNumeros = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        const string caracteresEspeciais = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+-=";
        const string caracteresTodos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=";
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoGerar_Click(object sender, EventArgs e)
        {
            textBoxSenha.Text = "";
            var random = new Random();
            if (!checkBoxNumeros.Checked && !checkBoxEspecial.Checked)
            {
                for (int i = 0; i < trackBarQuantidade.Value; i++)
                {

                    StringBuilder senha = new StringBuilder();
                    textBoxSenha.Text += senha.Append(caracteresNormais[random.Next(caracteresNormais.Length)]);
                }
            }
            else if (!checkBoxEspecial.Checked)
            {
                for (int i = 0; i < trackBarQuantidade.Value; i++)
                {
                    StringBuilder senha = new StringBuilder();
                    textBoxSenha.Text += senha.Append(caracteresNumeros[random.Next(caracteresNumeros.Length)]);
                }
            }
            else if (!checkBoxNumeros.Checked)
            {
                for (int i = 0; i < trackBarQuantidade.Value; i++)
                {
                    StringBuilder senha = new StringBuilder();
                    textBoxSenha.Text += senha.Append(caracteresEspeciais[random.Next(caracteresEspeciais.Length)]);
                }
            }
            else
            {
                for (int i = 0; i < trackBarQuantidade.Value; i++)
                {
                    StringBuilder senha = new StringBuilder();
                    textBoxSenha.Text += senha.Append(caracteresTodos[random.Next(caracteresTodos.Length)]);
                }
            }
        }

        private void trackBarQuantidade_Scroll(object sender, EventArgs e)
        {
            valorQuantidade.Text = trackBarQuantidade.Value.ToString();
        }
    }
}