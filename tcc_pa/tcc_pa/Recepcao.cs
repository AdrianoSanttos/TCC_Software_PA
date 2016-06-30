using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TCC_PA
{
    public partial class Recepcao : Form
    {
        public Recepcao()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pergunta2 formPergunta = new Pergunta2();
            formPergunta.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perfil formPerfil = new Perfil();
            formPerfil.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agendar formAgendar = new Agendar();
            formAgendar.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PA formLogin = new PA();
            if (MessageBox.Show("Deseja encerrar a seção?",
                 "SEÇÃO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                formLogin.ShowDialog();
                this.Close();
            }
        }
    }
}
