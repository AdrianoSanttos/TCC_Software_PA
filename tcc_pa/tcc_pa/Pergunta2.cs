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
    public partial class Pergunta2 : Form
    {
        Thread th;
        int total = 0;

        public Pergunta2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            label1.BackColor = Color.Transparent;
            ToolTip tool = new ToolTip();
            tool.SetToolTip(this.btnZerar, "Caso tenha apertado algum sintoma errado, clique aqui para voltar ao zero.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total += 10;
            botao1.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total += 20;
            botao2.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total += 30;
            botao3.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button4_Click(object sender, EventArgs e)
        {
            total += 40;
            botao4.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button5_Click(object sender, EventArgs e)
        {
            total += 50;
            botao5.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button6_Click(object sender, EventArgs e)
        {
            total += 60;
            botao6.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button7_Click(object sender, EventArgs e)
        {
            total += 70;
            botao7.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button8_Click(object sender, EventArgs e)
        {
            total += 80;
            botao8.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button9_Click(object sender, EventArgs e)
        {
            total += 90;
            botao9.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button10_Click(object sender, EventArgs e)
        {
            total += 100;
            botao10.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button11_Click(object sender, EventArgs e)
        {
            total += 110;
            botao11.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button12_Click(object sender, EventArgs e)
        {
            total += 120;
            botao12.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button13_Click(object sender, EventArgs e)
        {
            total += 130;
            botao13.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button14_Click(object sender, EventArgs e)
        {
            total += 140;
            botao14.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button15_Click(object sender, EventArgs e)
        {
            total += 150;
            botao15.Enabled = false; //Desabilita o botão após ser clicado
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Sintoma fSintoma = new Sintoma();
            switch (total)
            {
                case 0:
                    //MessageBox.Show("Sem sintomas");
                    fSintoma.SetInfromações("Sem sintomas", "Sem descrição por falta de sintomas");
                    //fSintoma.ShowDialog();
                    break;
                case 200:
                case 110:
                    //MessageBox.Show("Sinusite");
                    fSintoma.SetInfromações("Sinusite", "Sinusite é uma inflamação da mucosa dos seios da face, região do crânio formada por cavidades ósseas ao redor do nariz, maçãs do rosto e olhos. A doença pode ser secundária a uma infecção, quadro alérgico ou qualquer fator que atrapalhe a correta drenagem de secreção dos seios da face.");
                    //fSintoma.ShowDialog();
                    break;
                case 40:
                    //MessageBox.Show("Alergia Respiratória");
                    fSintoma.SetInfromações("Alergia Respiratória", "A alergia respiratória é uma resposta exagerada do sistema imune a substâncias como pó, pólen, poluição e fumaça, por exemplo, provocando doenças, como rinite, asma ou sinusite. Geralmente, a alergia respiratória é mais comum em alguns indivíduos com predisposição genética, surgindo na Primavera ou Inverno, devido à diminuição da umidade e ao aumento da concentração destas substâncias no ar.");
                    //fSintoma.ShowDialog();
                    break;
                case 50:
                case 60:
                    //MessageBox.Show("Inflamação na Garganta");
                    fSintoma.SetInfromações("Inflamação na Garganta", "A maioria dos casos de dor de garganta indicam doenças ou inflamações leves, que cessam sem tratamento médico ou então com o uso tópico de anti-inflamatórios.");
                    //fSintoma.ShowDialog();
                    break;
                case 130:
                    //MessageBox.Show("Gripe ou Virose");
                    fSintoma.SetInfromações("Gripe ou Virose", "");
                    fSintoma.ShowDialog();
                    break;
                case 30:
                    //MessageBox.Show("Gripe");
                    fSintoma.SetInfromações("Gripe", "Também conhecida como influenza, a gripe é uma infecção do sistema respiratório cuja principal complicação é a pneumonia, responsável por um grande número de internações hospitalares no país.");
                    //fSintoma.ShowDialog();
                    break;
                case 10:
                case 180:
                case 100:
                    //MessageBox.Show("Virose");
                    fSintoma.SetInfromações("Virose", "A gastroenterocolite aguda é uma infecção do sistema digestivo (estômago, intestino delgado e grosso), geralmente causada por um vírus. É o que costumamos chamar popularmente de 'virose'. De acordo com o infectologista Alexandre Naime Barbosa, da Unesp, a principal via de transmissão é o consumo de água contaminada ou de alimentos mal lavados ou mal cozidos, que estiveram em contato água contaminada com fezes.");
                    //fSintoma.ShowDialog();
                    break;
                case 120:
                case 250:
                    //MessageBox.Show("Labirintite");
                    fSintoma.SetInfromações("Labirintite", "A labirintite é uma doença do ouvido que afeta o labirinto e suas estruturas responsáveis pela audição (cóclea) e pelo equilíbrio (vestíbulo). As pessoas costumam chamar qualquer distúrbio na região do ouvido interno de labirintite. O termo correto é labirintopatia, sendo labirintite uma delas.");
                    //fSintoma.ShowDialog();
                    break;
                case 20:
                    //MessageBox.Show("Enxaqueca");
                    fSintoma.SetInfromações("Enxaqueca", "A enxaqueca é um dos tipos de cefaleia (dor de cabeça). A enxaqueca se caracteriza por uma dor pulsátil em um dos lados da cabeça (às vezes dos dois), geralmente acompanhada de fotofobia e fonofobia, náusea e vômito. A duração da crise varia de quatro a 72 horas, podendo ser mais curta em crianças.");
                    //fSintoma.ShowDialog();
                    break;
                case 70:
                    //MessageBox.Show("Intoxicação Alimentar");
                    fSintoma.SetInfromações("Intoxicação Alimentar", "A intoxicação alimentar é uma doença causada pela ingestão de alimentos que contém organismos prejudiciais ao nosso corpo, como bactérias, parasitas e vírus. Eles são encontrados principalmente na carne crua, frango, peixe e ovos, mas podem se espalhar para qualquer tipo de alimento.");
                    //fSintoma.ShowDialog();
                    break;
                case 80:
                    //MessageBox.Show("Diarréia");
                    fSintoma.SetInfromações("Diarréia", "A diarreia é uma doença muito comum que consiste na evacuação de fezes líquidas de forma frequente e sem controle. Ela pode ser tanto aguda quanto crônica, dependendo do tempo de duração dos sintomas.");
                    //fSintoma.ShowDialog();
                    break;
                case 90:
                case 140:
                    //MessageBox.Show("Falta de Vitamina no organismo");
                    fSintoma.SetInfromações("Falta de Vitamina no organismo", "A falta de vitaminas, ou avitaminose, é a carência de vitaminas no corpo, causada pela má absorção do organismo ou pela falta de ingestão vitamínica em forma de alimento ou suplemento. As vitaminas são necessárias para o bom funcionamento do corpo humano e estão presente nos alimentos em geral, mas especialmente nas frutas e legumes.");
                    //fSintoma.ShowDialog();
                    break;
                case 150:
                    //MessageBox.Show("Terçol");
                    fSintoma.SetInfromações("Terçol", "O terçol, ou hordéolo, é uma pequena infecção de uma glândula sebácea Zeiss e Mol, causada por bactérias, geralmente estreptococo ou estafilococo e, dependendo de sua localização, pode ser interno ou externo, atingindo a margem palpebral ou a parte do olho que se conecta aos cílios. A região onde aparece esta afcção fica inchada e dolorida.");
                    //fSintoma.ShowDialog();
                    break;
                default:
                    fSintoma.SetInfromações("Desconhecido", "Não foi identificado nenhum diagnóstico para seus sintomas, prossiga para a triagem.");
                    //fSintoma.ShowDialog();
                    break;
            }
            fSintoma.ShowDialog();
            this.Close();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new Recepcao());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ZerarSintomas();
            total = 0;
        }

        private void ZerarSintomas()
        {
            botao1.Enabled = true;
            botao2.Enabled = true;
            botao3.Enabled = true;
            botao4.Enabled = true;
            botao5.Enabled = true;
            botao6.Enabled = true;
            botao7.Enabled = true;
            botao8.Enabled = true;
            botao9.Enabled = true;
            botao10.Enabled = true;
            botao11.Enabled = true;
            botao12.Enabled = true;
            botao13.Enabled = true;
            botao14.Enabled = true;
            botao15.Enabled = true;
        }
    }
}
