namespace ImpressaoZebra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnPrint = new System.Windows.Forms.Button();
            this.txtIpPDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMinhaLe = new System.Windows.Forms.Label();
            this.lblRegular = new System.Windows.Forms.Label();
            this.lblPrecoMinhaLe = new System.Windows.Forms.Label();
            this.lblCodigoMercadoria = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPrecoRegular = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPrint.ForeColor = System.Drawing.Color.White;
            this.BtnPrint.Location = new System.Drawing.Point(380, 18);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(80, 21);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "IMPRIMIR";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            this.BtnPrint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnPrint_KeyDown);
            // 
            // txtIpPDV
            // 
            this.txtIpPDV.Location = new System.Drawing.Point(231, 46);
            this.txtIpPDV.Name = "txtIpPDV";
            this.txtIpPDV.Size = new System.Drawing.Size(120, 20);
            this.txtIpPDV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(168, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP do PDV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(112, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EAN/Cod. SAP";
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(193, 19);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(181, 20);
            this.txtEAN.TabIndex = 3;
            this.txtEAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEAN_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.lblMinhaLe);
            this.groupBox2.Controls.Add(this.lblRegular);
            this.groupBox2.Controls.Add(this.lblPrecoMinhaLe);
            this.groupBox2.Controls.Add(this.lblCodigoMercadoria);
            this.groupBox2.Controls.Add(this.lblDescricao);
            this.groupBox2.Controls.Add(this.lblPrecoRegular);
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 143);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lblMinhaLe
            // 
            this.lblMinhaLe.AutoSize = true;
            this.lblMinhaLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinhaLe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMinhaLe.Location = new System.Drawing.Point(353, 89);
            this.lblMinhaLe.Name = "lblMinhaLe";
            this.lblMinhaLe.Size = new System.Drawing.Size(84, 20);
            this.lblMinhaLe.TabIndex = 14;
            this.lblMinhaLe.Text = "Minha LE";
            this.lblMinhaLe.Visible = false;
            // 
            // lblRegular
            // 
            this.lblRegular.AutoSize = true;
            this.lblRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegular.Location = new System.Drawing.Point(19, 90);
            this.lblRegular.Name = "lblRegular";
            this.lblRegular.Size = new System.Drawing.Size(72, 20);
            this.lblRegular.TabIndex = 13;
            this.lblRegular.Text = "Regular";
            this.lblRegular.Visible = false;
            // 
            // lblPrecoMinhaLe
            // 
            this.lblPrecoMinhaLe.AutoSize = true;
            this.lblPrecoMinhaLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoMinhaLe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecoMinhaLe.Location = new System.Drawing.Point(351, 109);
            this.lblPrecoMinhaLe.Name = "lblPrecoMinhaLe";
            this.lblPrecoMinhaLe.Size = new System.Drawing.Size(51, 31);
            this.lblPrecoMinhaLe.TabIndex = 13;
            this.lblPrecoMinhaLe.Text = "R$";
            this.lblPrecoMinhaLe.Visible = false;
            // 
            // lblCodigoMercadoria
            // 
            this.lblCodigoMercadoria.AutoSize = true;
            this.lblCodigoMercadoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoMercadoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodigoMercadoria.Location = new System.Drawing.Point(18, 16);
            this.lblCodigoMercadoria.Name = "lblCodigoMercadoria";
            this.lblCodigoMercadoria.Size = new System.Drawing.Size(65, 20);
            this.lblCodigoMercadoria.TabIndex = 6;
            this.lblCodigoMercadoria.Text = "Código";
            this.lblCodigoMercadoria.Visible = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescricao.Location = new System.Drawing.Point(17, 50);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(117, 25);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Visible = false;
            // 
            // lblPrecoRegular
            // 
            this.lblPrecoRegular.AutoSize = true;
            this.lblPrecoRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoRegular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecoRegular.Location = new System.Drawing.Point(16, 109);
            this.lblPrecoRegular.Name = "lblPrecoRegular";
            this.lblPrecoRegular.Size = new System.Drawing.Size(51, 31);
            this.lblPrecoRegular.TabIndex = 4;
            this.lblPrecoRegular.Text = "R$";
            this.lblPrecoRegular.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIpPDV);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 72);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexão com o PDV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(111, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe o IP de um PDV LIGADO e ATUALIZADO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtEAN);
            this.groupBox3.Controls.Add(this.BtnPrint);
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(12, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 50);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mercadoria";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ImpressaoZebra.Properties.Resources.logo_sysaid1216891450_trial__1_;
            this.pictureBox3.Location = new System.Drawing.Point(225, 287);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ImpressaoZebra.Properties.Resources.minhaLeGrande;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(609, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ImpressaoZebra.Properties.Resources._05_1_precificacao_servico;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(4)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(608, 466);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precificador de contingência";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.TextBox txtIpPDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCodigoMercadoria;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPrecoRegular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecoMinhaLe;
        private System.Windows.Forms.Label lblMinhaLe;
        private System.Windows.Forms.Label lblRegular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

