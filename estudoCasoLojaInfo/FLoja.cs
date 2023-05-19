using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudoCasoLojaInfo
{
    public partial class FLoja : Form
    {
        ClsProduto objProduto = new ClsProduto();        
        DialogResult messageBoxException;        

        public FLoja()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
            LimpaFormulario();                    
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitaBotaoSalvar();
            //objProduto.Estoque = 0;
            txtEstoque.Text = "";

            if (cboProduto.SelectedIndex != 0)
            {
                var dadosProduto = objProduto.ConsultarArquivos(cboProduto.Text);
                
                foreach (var c in dadosProduto)
                {
                    if (c.NomeProduto != "" && c.QuantidadePorOperacao != 0 && c.Estoque != 0)
                    {
                        txtEstoque.Text = $"{c.Estoque}";                        
                    }
                }
                if(objProduto.Estoque == 0 && txtEstoque.Text == "")
                {                    
                    txtEstoque.Text = $"{objProduto.Estoque}"; 
                }
            }
        }

       

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCamposFormulario();
            
            if (ValidaLimpaFormulario())
            {
               var resultado = MessageBox.Show("Tem certeza que deseja limpar todos os campos?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(resultado == DialogResult.Yes)
                {
                    LimpaFormulario();                    
                }                              
            }
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            txtHistorico.Clear();

            var dados = objProduto.ConsultaArquivo();
            
                foreach (var c in dados)
                {
                    txtHistorico.Text += $"Produto: {c.NomeProduto} - Estoque: {c.Estoque} - " +
                    $"Qtde de Movimentação: {c.QuantidadePorOperacao}\r\n";
                }
                if (txtHistorico.Text == "")
                {
                    MessageBox.Show(
                        "Não há produtos salvos",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }            
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            HabilitaBotaoSalvar();
        }

        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {
            HabilitaBotaoSalvar();
        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {
            HabilitaBotaoSalvar();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            HabilitaBotaoSalvar();            
        }

        private void txtQtdeMovimentar_TextChanged(object sender, EventArgs e)
        {
            HabilitaBotaoSalvar();            
        }

        private void rBtnCompra_CheckedChanged(object sender, EventArgs e)
        {            
            HabilitaBotaoSalvar();
            if (rBtnCompra.Checked)
            {
                txtLucro.Enabled = false;
                txtLucro.Visible = false;
                txtLucro.Clear();
                txtLucro.Text = "0";

            }
        }

        private void rBtnVenda_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaBotaoSalvar();
           
                txtLucro.Enabled = true;
                txtLucro.Visible = true;
               
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {         

            if(cboProduto.SelectedIndex != 0)
            {
                RecuperaDadosForm();

                if(messageBoxException == DialogResult.OK)
                {
                    messageBoxException = DialogResult.Cancel;
                }                
                else if (ProibeCampoMenorQueZero())
                {
                    DialogResult result = MessageBox.Show("Os dados estão corretos?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result == DialogResult.Yes)
                    {
                        if (rBtnCompra.Checked == true)
                        {
                            //if (EscolheIndexComboBox())
                            //{
                                txtTotal.Text =  $"{objProduto.ComprarProduto():c}" ;
                                txtEstoque.Text = $"{objProduto.AumentaEstoque()}";
                                objProduto.GravarMovimentacao();
                                MostraMensagemSucesso();
                                
                            //}

                        }
                        else
                        {
                            //if (EscolheIndexComboBox())
                            //{
                                if(ValidaEstoqueMaiorQueVenda())
                                {
                                    txtTotal.Text = $"{objProduto.PrecoVenda():c}";
                                    txtEstoque.Text = $"{objProduto.DiminuiEstoque()}";                                
                                    objProduto.GravarMovimentacao();
                                    MostraMensagemSucesso();
                                }
                                else
                                {
                                    MessageBox.Show("Saldo Insuficiente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }                            
                            //}                     
                        }
                        //objProduto.GravarMovimentacao();
                    } else if (result == DialogResult.No)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Digite valores positivos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if(cboProduto.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione um Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var dadosProduto = objProduto.ConsultarArquivos(cboProduto.Text);
                txtHistorico.Clear();

                foreach(var c in dadosProduto)
                {
                    if(c.NomeProduto != "" && c.QuantidadePorOperacao != 0 && c.Estoque != 0)
                    {
                        txtEstoque.Text = $"{c.Estoque}";
                        txtHistorico.Text += $"Produto: {c.NomeProduto}; Estoque: {c.Estoque};" +
                             $"Qtde de Movimentação: {c.QuantidadePorOperacao}\r\n";
                    }
                } 
                if(txtHistorico.Text == "")
                {
                    MessageBox.Show("Não há em estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Métodos Personalizados
        private void DesabilitaCampos()
        {
            txtLucro.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtQtdeMovimentar.Enabled = false;
            txtEstoque.Enabled = false;
            txtTotal.Enabled = false;

            cboProduto.Enabled = false;

            rBtnCompra.Enabled = false;
            rBtnVenda.Enabled = false;

            btnSalvar.Enabled = false;
            btnConsultar.Enabled = false;
        }

        private void HabilitaCamposFormulario()
        {
            txtLucro.Enabled = true;
            txtLucro.Visible = true;
            txtPrecoCusto.Enabled = true;
            txtQtdeMovimentar.Enabled = true;            

            cboProduto.Enabled = true;

            rBtnCompra.Enabled = true;
            rBtnVenda.Enabled = true;
            
            btnConsultar.Enabled = true;
        }

        private void LimpaFormulario()
        {
            cboProduto.SelectedIndex = 0;

            rBtnCompra.Checked = false;
            rBtnVenda.Checked = false;            
            
            txtLucro.Clear();
            txtPrecoCusto.Clear();
            txtQtdeMovimentar.Clear();
            txtEstoque.Clear();
            txtTotal.Clear();
            txtHistorico.Clear();
            objProduto = new();
        }

        public Boolean ValidaLimpaFormulario()
        {

            if (txtLucro.Text.Trim() != "" ||
                txtPrecoCusto.Text.Trim() != "" ||
                txtQtdeMovimentar.Text.Trim() != "" ||
                txtEstoque.Text.Trim() != "" ||
                txtTotal.Text.Trim() != "" ||
                rBtnCompra.Checked != false ||
                rBtnVenda.Checked != false ||
                cboProduto.SelectedIndex != 0)
            {
                return true;

            }            
                return false;            
        }

        public void HabilitaBotaoSalvar()
        {
                            
            if( txtLucro.Text.Trim() == "" ||
                txtPrecoCusto.Text.Trim() == "" ||
                txtQtdeMovimentar.Text.Trim() == "" ||
                //txtEstoque.Text == "" ||                
                rBtnCompra.Checked == false &&
                rBtnVenda.Checked == false ||
                cboProduto.SelectedIndex == 0)
            {
                btnSalvar.Enabled = false;                
            }              
            else
            {
                btnSalvar.Enabled = true;
            }
        } 
        
        public void RecuperaDadosForm()
        {
            try
            {
                objProduto.NomeProduto = cboProduto.Text;
                objProduto.PrecoCusto = double.Parse(txtPrecoCusto.Text.Replace(".",","));
                objProduto.QuantidadePorOperacao = int.Parse(txtQtdeMovimentar.Text);                
                objProduto.LucroPorProduto = double.Parse(txtLucro.Text.Replace(".", ","));
                objProduto.Estoque = int.Parse(txtEstoque.Text);                
            }
            catch (FormatException)
            {
               messageBoxException = MessageBox.Show("Campos aceitam somente números positivos e campo 'Quantidade' somente números inteiros positivos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Boolean ProibeCampoMenorQueZero()
        {
            if(objProduto.QuantidadePorOperacao <= 0 || objProduto.PrecoCusto <= 0 || objProduto.LucroPorProduto < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean EscolheIndexComboBox()
        {
            if (
                cboProduto.SelectedIndex == 1 ||
                cboProduto.SelectedIndex == 2 ||
                cboProduto.SelectedIndex == 3 ||
                cboProduto.SelectedIndex == 4 ||
                cboProduto.SelectedIndex == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ValidaEstoqueMaiorQueVenda()
        {
            if(objProduto.Estoque < objProduto.QuantidadePorOperacao)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void MostraMensagemSucesso()
        {
            MessageBox.Show("Dados Salvos!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesabilitaCampos();
            LimpaFormulario();
            txtLucro.Enabled = false;
        }       
    }    
}
