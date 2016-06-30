using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_PA
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            lblPerfil.BackColor = Color.Transparent;
            lblNome.BackColor = Color.Transparent;
            lblTelefone.BackColor = Color.Transparent;
            lblIdade.BackColor = Color.Transparent;
            lblCPF.BackColor = Color.Transparent;
            lblRegistro.BackColor = Color.Transparent;
            lblPlanoSaude.BackColor = Color.Transparent;
            lblUltPassagem.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;

            gbPerfil.BackColor = Color.Transparent;
        }

        private void bt_voltar_Click_1(object sender, EventArgs e)
        {
            Recepcao formRecepcao = new Recepcao();
            formRecepcao.ShowDialog();
            this.Close();
        }
    }
}
