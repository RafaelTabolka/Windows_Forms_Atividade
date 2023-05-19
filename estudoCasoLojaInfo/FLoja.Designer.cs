
namespace estudoCasoLojaInfo
{
    partial class FLoja
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdeMovimentar = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.rBtnVenda = new System.Windows.Forms.RadioButton();
            this.rBtnCompra = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Items.AddRange(new object[] {
            "Selecione",
            "HD 500 GB",
            "HD 1TB",
            "PENDRIVE",
            "MONITOR",
            "CABO HDMI"});
            this.cboProduto.Location = new System.Drawing.Point(196, 57);
            this.cboProduto.Margin = new System.Windows.Forms.Padding(6);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(226, 39);
            this.cboProduto.TabIndex = 8;
            this.cboProduto.SelectedIndexChanged += new System.EventHandler(this.cboProduto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estoque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade:";
            // 
            // txtQtdeMovimentar
            // 
            this.txtQtdeMovimentar.Location = new System.Drawing.Point(576, 150);
            this.txtQtdeMovimentar.Margin = new System.Windows.Forms.Padding(6);
            this.txtQtdeMovimentar.Name = "txtQtdeMovimentar";
            this.txtQtdeMovimentar.Size = new System.Drawing.Size(157, 39);
            this.txtQtdeMovimentar.TabIndex = 9;
            this.txtQtdeMovimentar.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(215, 153);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(6);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.ReadOnly = true;
            this.txtEstoque.Size = new System.Drawing.Size(155, 39);
            this.txtEstoque.TabIndex = 10;
            this.txtEstoque.TextChanged += new System.EventHandler(this.txtQtdeMovimentar_TextChanged);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(94, 507);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(6);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(795, 181);
            this.txtHistorico.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 464);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Histórico de Compra e Venda";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = global::estudoCasoLojaInfo.Properties.Resources.pesquisa;
            this.btnConsultar.Location = new System.Drawing.Point(431, 41);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(63, 67);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::estudoCasoLojaInfo.Properties.Resources.novo;
            this.btnNovo.Location = new System.Drawing.Point(370, 362);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(92, 83);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = global::estudoCasoLojaInfo.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(509, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 85);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Image = global::estudoCasoLojaInfo.Properties.Resources.consultar;
            this.btnHistorico.Location = new System.Drawing.Point(911, 543);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(92, 88);
            this.btnHistorico.TabIndex = 21;
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "%Lucro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Preço Custo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total:";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(239, 270);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(138, 39);
            this.txtPrecoCusto.TabIndex = 25;
            this.txtPrecoCusto.TextChanged += new System.EventHandler(this.txtPrecoCusto_TextChanged);
            // 
            // txtLucro
            // 
            this.txtLucro.Location = new System.Drawing.Point(483, 270);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(138, 39);
            this.txtLucro.TabIndex = 26;
            this.txtLucro.TextChanged += new System.EventHandler(this.txtLucro_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(215, 332);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 39);
            this.txtTotal.TabIndex = 27;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // rBtnVenda
            // 
            this.rBtnVenda.AutoSize = true;
            this.rBtnVenda.Location = new System.Drawing.Point(627, 300);
            this.rBtnVenda.Name = "rBtnVenda";
            this.rBtnVenda.Size = new System.Drawing.Size(101, 36);
            this.rBtnVenda.TabIndex = 28;
            this.rBtnVenda.TabStop = true;
            this.rBtnVenda.Text = "Venda";
            this.rBtnVenda.UseVisualStyleBackColor = true;
            this.rBtnVenda.CheckedChanged += new System.EventHandler(this.rBtnVenda_CheckedChanged);
            // 
            // rBtnCompra
            // 
            this.rBtnCompra.AutoSize = true;
            this.rBtnCompra.Location = new System.Drawing.Point(627, 335);
            this.rBtnCompra.Name = "rBtnCompra";
            this.rBtnCompra.Size = new System.Drawing.Size(119, 36);
            this.rBtnCompra.TabIndex = 29;
            this.rBtnCompra.TabStop = true;
            this.rBtnCompra.Text = "Compra";
            this.rBtnCompra.UseVisualStyleBackColor = true;
            this.rBtnCompra.CheckedChanged += new System.EventHandler(this.rBtnCompra_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 32);
            this.label7.TabIndex = 30;
            this.label7.Text = "Operação";
            // 
            // FLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 719);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rBtnCompra);
            this.Controls.Add(this.rBtnVenda);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txtPrecoCusto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQtdeMovimentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstoque);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdeMovimentar;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton rBtnVenda;
        private System.Windows.Forms.RadioButton rBtnCompra;
        private System.Windows.Forms.Label label7;
    }
}

