using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using trabalho.db;

namespace trabalho.Model
{
    public class CarroModel : AbstractProdutoModel
    {
        public string modelo_carro;
        public string marca_carro;
        public string cor_carro;
        public string nome_carro;
        public Boolean airbag_carro;

        public CarroModel()
        {

        }

        public CarroModel (string modelo_carro, string marca_carro, string cor_carro, string nome_carro, bool airbag_carro)
        {
            this.modelo_carro = modelo_carro;
            this.marca_carro = marca_carro;
            this.cor_carro = cor_carro;
            this.nome_carro = nome_carro;
            this.airbag_carro = airbag_carro;
        }

        public void salvar()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Carro (modelo_carro,marca_carro,cor_carro,nome_carro,airbag_carro,qtdestoque_carro,preco_carro) " +
                                             "VALUES (@modelo_carro, @marca_carro, @cor_carro, @nome_carro, @airbag_carro, @qtdestoque, @preco)";

            command.Parameters.AddWithValue("@modelo_carro", this.modelo_carro);
            command.Parameters.AddWithValue("@marca_carro", this.marca_carro);
            command.Parameters.AddWithValue("@cor_carro", this.cor_carro);
            command.Parameters.AddWithValue("@nome_carro", this.nome_carro);
            command.Parameters.AddWithValue("@airbag_carro", this.airbag_carro);
            command.Parameters.AddWithValue("@qtdestoque", this.qtdEstoque);
            command.Parameters.AddWithValue("@preco", this.preco);
                        
            Conexao.CRUD(command);
        }

        public CarroModel selectById(int id)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM Carro WHERE id_carro=@id_carro";

            command.Parameters.AddWithValue("@id_carro", id);
            
            NpgsqlDataReader dr = Conexao.Select(command);

            if(dr.HasRows)
            {
                dr.Read();
                this.id = (int)dr["id_carro"];
                this.modelo_carro = (string)dr["modelo_carro"];
                this.marca_carro = (string)dr["marca_carro"];
                this.cor_carro = (string)dr["cor_carro"];
                this.nome_carro = (string)dr["nome_carro"];
                this.airbag_carro = (bool)dr["airbag_carro"];
                this.qtdEstoque = (int)dr["qtdestoque_carro"];
                this.preco = (double)dr["preco_carro"];
                
                return this;
            }

            return this;
        }
    }
}
