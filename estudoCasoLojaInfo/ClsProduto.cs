using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoCasoLojaInfo
{
    class ClsProduto
    {
        private string nomeProduto;
        private int estoque;
        private int quantidadePorOperacao;
        private double precoCusto;
        private double lucroPorProduto;

        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }

        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }    
        }
        public int QuantidadePorOperacao
        {
            get { return quantidadePorOperacao; }
            set { quantidadePorOperacao = value; }
        }
        public double PrecoCusto
        {
            get { return precoCusto; }
            set { precoCusto = value; }
        }
        public double LucroPorProduto
        {
            get { return lucroPorProduto; }
            set { lucroPorProduto = value; }
        }

        public double PrecoVenda()
        {
            if(lucroPorProduto > 0)
            {
                return (precoCusto * lucroPorProduto / 100 + precoCusto) * quantidadePorOperacao;

            }
            return precoCusto * quantidadePorOperacao;
        }
        public double ComprarProduto()
        {
            return precoCusto * quantidadePorOperacao;
        }

        public int AumentaEstoque()
        {
            return estoque += quantidadePorOperacao;
        }

        public int DiminuiEstoque()
        {
            return estoque -= quantidadePorOperacao;
        }

        public List<ClsProduto> ConsultaArquivo()
        {
            var listaProdutos = new List<ClsProduto>();

            string arquivoCaminho = @"C:/arquivos/produto.txt";

            if (File.Exists(arquivoCaminho))
            {
                using var arquivo = new StreamReader(arquivoCaminho);
                
                string linhaArquivo;
                int i = 0;

                while((linhaArquivo = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue;

                    var contaArquivo = linhaArquivo.Split(";");

                    var produto = new ClsProduto();

                    produto.nomeProduto = contaArquivo[0];
                    produto.estoque = int.Parse(contaArquivo[1]);
                    produto.quantidadePorOperacao = int.Parse(contaArquivo[2]);     
                    
                    listaProdutos.Add(produto);
                }
                arquivo.Close();
            }
            return listaProdutos;
        }

        public void GravarMovimentacao()
        {
            var listaProdutos = ConsultaArquivo();
            listaProdutos.Add(this);
            string arquivoCaminho = @"C:/arquivos/produto.txt";

            if (File.Exists(arquivoCaminho))
            {
                StreamWriter escreverArquivo = new StreamWriter(arquivoCaminho);

                escreverArquivo.WriteLine("Nome do Produto;Estoque;Quantidade por Operação");

                foreach (var c in listaProdutos)
                {
                    var linha = $"{c.NomeProduto};{c.Estoque};{c.QuantidadePorOperacao}";
                    escreverArquivo.WriteLine(linha);
                }
                escreverArquivo.Close();
            }            
        }

        public List<ClsProduto> ConsultarArquivos(string produto)
        {
            var listaProdutos = new List<ClsProduto>();

            string arquivoCaminho = @"C:/arquivos/produto.txt";

            if (File.Exists(arquivoCaminho))
            {
                using var arquivo = new StreamReader(arquivoCaminho);

                string linhaArquivo;
                int i = 0;

                while ((linhaArquivo = arquivo.ReadLine()) != null)
                {
                    i++;
                    if (i == 1) continue;

                    var contaArquivo = linhaArquivo.Split(';');

                    var objProduto = new ClsProduto();

                    if (contaArquivo[0] == produto)
                    {
                        objProduto.NomeProduto = contaArquivo[0];
                        objProduto.Estoque = int.Parse(contaArquivo[1]);
                        objProduto.quantidadePorOperacao = int.Parse(contaArquivo[2]);
                        
                    }

                    listaProdutos.Add(objProduto);
                }
                arquivo.Close();
            }
            return listaProdutos;
        }
    }
}

        

