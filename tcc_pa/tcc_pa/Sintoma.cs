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
    public partial class Sintoma : Form
    {
        public Sintoma()
        {
            InitializeComponent();

            lblDiag.BackColor = Color.Transparent;
            lblDiagResultado.BackColor = Color.Transparent;
            lblDescResult.BackColor = Color.Transparent;
            lblDescricao.BackColor = Color.Transparent;
            lblDescResult.MaximumSize = new Size(550, 0);
            lblPreDiag.BackColor = Color.Transparent;
        }

        public void SetInfromações(string sintoma, string descricao)
        {
            lblDiagResultado.Text = sintoma;
            lblDescResult.Text = descricao;
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            Recepcao formRecepcao = new Recepcao();
            formRecepcao.ShowDialog();
            this.Close();
        }

    }
}
