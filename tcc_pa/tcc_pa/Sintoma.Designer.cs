namespace TCC_PA
{
    partial class Sintoma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sintoma));
            this.lblDiag = new System.Windows.Forms.Label();
            this.lblDiagResultado = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDescResult = new System.Windows.Forms.Label();
            this.lblPreDiag = new System.Windows.Forms.Label();
            this.bt_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.Location = new System.Drawing.Point(258, 258);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(146, 29);
            this.lblDiag.TabIndex = 0;
            this.lblDiag.Text = "Diagnóstico:";
            // 
            // lblDiagResultado
            // 
            this.lblDiagResultado.AutoSize = true;
            this.lblDiagResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagResultado.Location = new System.Drawing.Point(410, 258);
            this.lblDiagResultado.Name = "lblDiagResultado";
            this.lblDiagResultado.Size = new System.Drawing.Size(0, 29);
            this.lblDiagResultado.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(258, 316);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(127, 29);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblDescResult
            // 
            this.lblDescResult.AutoSize = true;
            this.lblDescResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescResult.Location = new System.Drawing.Point(410, 316);
            this.lblDescResult.Name = "lblDescResult";
            this.lblDescResult.Size = new System.Drawing.Size(0, 29);
            this.lblDescResult.TabIndex = 3;
            // 
            // lblPreDiag
            // 
            this.lblPreDiag.AutoSize = true;
            this.lblPreDiag.BackColor = System.Drawing.SystemColors.Control;
            this.lblPreDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreDiag.Location = new System.Drawing.Point(343, 140);
            this.lblPreDiag.Name = "lblPreDiag";
            this.lblPreDiag.Size = new System.Drawing.Size(631, 44);
            this.lblPreDiag.TabIndex = 4;
            this.lblPreDiag.Text = "PRÉ DIAGNÓSTICO REALIZADO!";
            // 
            // bt_voltar
            // 
            this.bt_voltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_voltar.BackgroundImage")));
            this.bt_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_voltar.Location = new System.Drawing.Point(92, 438);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(207, 75);
            this.bt_voltar.TabIndex = 18;
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // Sintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::TCC_PA.Properties.Resources.apresentacao_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 682);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.lblPreDiag);
            this.Controls.Add(this.lblDescResult);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblDiagResultado);
            this.Controls.Add(this.lblDiag);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sintoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label lblDiagResultado;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDescResult;
        private System.Windows.Forms.Label lblPreDiag;
        private System.Windows.Forms.Button bt_voltar;
    }
}