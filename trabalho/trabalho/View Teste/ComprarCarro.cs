using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using trabalho.Model;
using trabalho.db;


namespace trabalho.View_Teste
{
    
    public partial class btn_finalizar_compra : Form
    {
        Compra compra = new Compra();
        public btn_finalizar_compra()
        {
            InitializeComponent();
            

            NpgsqlCommand con = new NpgsqlCommand();
            con.Connection = Conexao.Connection();
            con.CommandType = CommandType.Text;
            con.CommandText = "SELECT * FROM Carro";
            NpgsqlDataReader dr = con.ExecuteReader();
            
            if(dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }

        }

        private void ComprarCarro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = ((int)nmr_cod_carro.Value);

            CarroModel carro = new CarroModel();
            carro = carro.selectById(cod);

            MessageBox.Show("Você compro o carro: " + carro.nome_carro);

            compra.lista.Add(carro);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            compra.lista = compra.lista;

            compra.id_compra = 1;
            compra.gravarCompra();
        }
    }
}
