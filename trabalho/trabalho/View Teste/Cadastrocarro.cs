using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho.Model;

namespace trabalho.View_Teste
{
    public partial class Cadastrocarro : Form
    {
        public Cadastrocarro()
        {
            InitializeComponent();
        }

        private void salvar_carro_Click(object sender, EventArgs e)
        {
            var modelo_carro = txb_modelo_carro.Text;
            var marca_carro = txb_marca_carro.Text;
            var cor_carro = txb_cor_carro.Text;
            var nome_carro = txb_nome_carro.Text;
            Boolean airbag;
            if(chb_airbag.Checked)
            {
                airbag = true;
            } 
            else
            {
                airbag = false;
            }

            var qtd_estoque = nmr_qtdestoque.Value;
            var preco_carro = nmr_preco.Value;

            CarroModel carroModel = new CarroModel(modelo_carro, marca_carro, cor_carro, nome_carro, airbag);
            
            try
            {
                carroModel.salvar();
                MessageBox.Show("Carro cadastrado com sucesso!");
            }
            catch(Exception )
            {
                MessageBox.Show("Erro ao cadastrar!");
            }

            Label label = new Label();
            label.Show();
            


        }
    }
}
