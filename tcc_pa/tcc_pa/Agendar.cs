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
    public partial class Agendar : Form
    {
        Recepcao formRecepcao = new Recepcao();
        DateTime dateConsultas = new DateTime(2015, 10, 5);
        DateTime dateConsultas1 = new DateTime(2015, 10, 6);
        DateTime dateConsultas2 = new DateTime(2015, 10, 7);
        DateTime dateConsultas3 = new DateTime(2015, 10, 8);
        DateTime dateConsultas4 = new DateTime(2015, 10, 14);

        public Agendar()
        {
            InitializeComponent();
            PreencheHorarios();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            lblTituloAgendar.BackColor = Color.Transparent;
            lblData.BackColor = Color.Transparent;
            lblValorData.BackColor = Color.Transparent;
            gbCalendario.BackColor = Color.Transparent;
            gbConfirma.BackColor = Color.Transparent;
            lblHorario.BackColor = Color.Transparent;


            mcDatasConsulta.AddBoldedDate(dateConsultas);
            mcDatasConsulta.AddBoldedDate(dateConsultas1);
            mcDatasConsulta.AddBoldedDate(dateConsultas2);
            mcDatasConsulta.AddBoldedDate(dateConsultas3);
            mcDatasConsulta.AddBoldedDate(dateConsultas4);
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            formRecepcao.ShowDialog();
            this.Close();
        }

        private void mcDatasConsulta_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblValorData.Text = mcDatasConsulta.SelectionRange.Start.ToShortDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void PreencheHorarios()
        {
            for(int i = 08; i <= 18; i++)
            {
                cbHorarios.Items.Add(i.ToString() + ":00h");
            }
                
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Agendamento de consulta realizado com sucesso!!!",
                "CONSULTA", MessageBoxButtons.OK) == DialogResult.OK)
            {
                formRecepcao.ShowDialog();
                this.Close();
            }
        }
    }
}
