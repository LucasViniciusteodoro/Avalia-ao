namespace Atividade
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxFechar = new System.Windows.Forms.PictureBox();
            this.pbxVenda = new System.Windows.Forms.PictureBox();
            this.pbxProduto = new System.Windows.Forms.PictureBox();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(883, 484);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fechar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Venda / Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pbxFechar
            // 
            this.pbxFechar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxFechar.ErrorImage")));
            this.pbxFechar.Image = global::Atividade.Properties.Resources.download;
            this.pbxFechar.Location = new System.Drawing.Point(861, 371);
            this.pbxFechar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxFechar.Name = "pbxFechar";
            this.pbxFechar.Size = new System.Drawing.Size(103, 111);
            this.pbxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFechar.TabIndex = 20;
            this.pbxFechar.TabStop = false;
            this.pbxFechar.Click += new System.EventHandler(this.pbxFechar_Click);
            // 
            // pbxVenda
            // 
            this.pbxVenda.Image = global::Atividade.Properties.Resources.pedido;
            this.pbxVenda.Location = new System.Drawing.Point(332, 27);
            this.pbxVenda.Margin = new System.Windows.Forms.Padding(2);
            this.pbxVenda.Name = "pbxVenda";
            this.pbxVenda.Size = new System.Drawing.Size(103, 111);
            this.pbxVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenda.TabIndex = 18;
            this.pbxVenda.TabStop = false;
            this.pbxVenda.Click += new System.EventHandler(this.pbxVenda_Click_1);
            // 
            // pbxProduto
            // 
            this.pbxProduto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxProduto.ErrorImage")));
            this.pbxProduto.Image = global::Atividade.Properties.Resources.download__1_;
            this.pbxProduto.Location = new System.Drawing.Point(174, 27);
            this.pbxProduto.Margin = new System.Windows.Forms.Padding(2);
            this.pbxProduto.Name = "pbxProduto";
            this.pbxProduto.Size = new System.Drawing.Size(103, 111);
            this.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProduto.TabIndex = 14;
            this.pbxProduto.TabStop = false;
            this.pbxProduto.Click += new System.EventHandler(this.pbxProduto_Click_1);
            // 
            // pbxCliente
            // 
            this.pbxCliente.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxCliente.ErrorImage")));
            this.pbxCliente.Image = global::Atividade.Properties.Resources.download__2_;
            this.pbxCliente.Location = new System.Drawing.Point(31, 27);
            this.pbxCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(103, 111);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 12;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 508);
            this.Controls.Add(this.pbxFechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxFechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.Label label1;
    }
}