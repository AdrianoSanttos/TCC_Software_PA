namespace TCC_PA
{
    partial class Agendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agendar));
            this.lblTituloAgendar = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.mcDatasConsulta = new System.Windows.Forms.MonthCalendar();
            this.gbCalendario = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValorData = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.gbConfirma = new System.Windows.Forms.GroupBox();
            this.cbHorarios = new System.Windows.Forms.ComboBox();
            this.button16 = new System.Windows.Forms.Button();
            this.gbCalendario.SuspendLayout();
            this.gbConfirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloAgendar
            // 
            this.lblTituloAgendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloAgendar.AutoSize = true;
            this.lblTituloAgendar.BackColor = System.Drawing.SystemColors.Control;
            this.lblTituloAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgendar.Location = new System.Drawing.Point(200, 123);
            this.lblTituloAgendar.Name = "lblTituloAgendar";
            this.lblTituloAgendar.Size = new System.Drawing.Size(602, 63);
            this.lblTituloAgendar.TabIndex = 28;
            this.lblTituloAgendar.Text = "AGENDAR CONSULTA";
            this.lblTituloAgendar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_voltar
            // 
            this.bt_voltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_voltar.BackgroundImage")));
            this.bt_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_voltar.Location = new System.Drawing.Point(78, 524);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(207, 75);
            this.bt_voltar.TabIndex = 29;
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // mcDatasConsulta
            // 
            this.mcDatasConsulta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mcDatasConsulta.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.mcDatasConsulta.Location = new System.Drawing.Point(12, 36);
            this.mcDatasConsulta.Name = "mcDatasConsulta";
            this.mcDatasConsulta.TabIndex = 30;
            this.mcDatasConsulta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcDatasConsulta_DateChanged);
            // 
            // gbCalendario
            // 
            this.gbCalendario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbCalendario.BackColor = System.Drawing.SystemColors.Control;
            this.gbCalendario.Controls.Add(this.mcDatasConsulta);
            this.gbCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalendario.Location = new System.Drawing.Point(147, 201);
            this.gbCalendario.Name = "gbCalendario";
            this.gbCalendario.Size = new System.Drawing.Size(717, 218);
            this.gbCalendario.TabIndex = 31;
            this.gbCalendario.TabStop = false;
            this.gbCalendario.Text = "Disponibilidade para consultas";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.SystemColors.Control;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(226, 31);
            this.lblData.TabIndex = 32;
            this.lblData.Text = "Data da consulta:";
            // 
            // lblValorData
            // 
            this.lblValorData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValorData.AutoSize = true;
            this.lblValorData.BackColor = System.Drawing.SystemColors.Control;
            this.lblValorData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorData.Location = new System.Drawing.Point(238, 33);
            this.lblValorData.Name = "lblValorData";
            this.lblValorData.Size = new System.Drawing.Size(0, 25);
            this.lblValorData.TabIndex = 33;
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.SystemColors.Control;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(369, 27);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(228, 31);
            this.lblHorario.TabIndex = 34;
            this.lblHorario.Text = "Horário desejado:";
            // 
            // gbConfirma
            // 
            this.gbConfirma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbConfirma.BackColor = System.Drawing.SystemColors.Control;
            this.gbConfirma.Controls.Add(this.cbHorarios);
            this.gbConfirma.Controls.Add(this.lblData);
            this.gbConfirma.Controls.Add(this.lblValorData);
            this.gbConfirma.Controls.Add(this.lblHorario);
            this.gbConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfirma.Location = new System.Drawing.Point(147, 425);
            this.gbConfirma.Name = "gbConfirma";
            this.gbConfirma.Size = new System.Drawing.Size(717, 85);
            this.gbConfirma.TabIndex = 36;
            this.gbConfirma.TabStop = false;
            this.gbConfirma.Text = "Confirmar consulta";
            // 
            // cbHorarios
            // 
            this.cbHorarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbHorarios.FormattingEnabled = true;
            this.cbHorarios.Location = new System.Drawing.Point(590, 30);
            this.cbHorarios.Name = "cbHorarios";
            this.cbHorarios.Size = new System.Drawing.Size(121, 28);
            this.cbHorarios.TabIndex = 35;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button16.BackgroundImage = global::TCC_PA.Properties.Resources.Agendar;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.ForeColor = System.Drawing.SystemColors.Control;
            this.button16.Location = new System.Drawing.Point(675, 524);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(236, 75);
            this.button16.TabIndex = 37;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Agendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::TCC_PA.Properties.Resources.apresentacao_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 729);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.gbConfirma);
            this.Controls.Add(this.gbCalendario);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.lblTituloAgendar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agendar";
            this.Text = "Agendar";
            this.gbCalendario.ResumeLayout(false);
            this.gbConfirma.ResumeLayout(false);
            this.gbConfirma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgendar;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.MonthCalendar mcDatasConsulta;
        private System.Windows.Forms.GroupBox gbCalendario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValorData;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.GroupBox gbConfirma;
        private System.Windows.Forms.ComboBox cbHorarios;
        private System.Windows.Forms.Button button16;
    }
}