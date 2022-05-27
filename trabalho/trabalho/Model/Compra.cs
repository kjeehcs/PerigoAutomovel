using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using trabalho.db;

namespace trabalho.Model
{
    public class Compra
    {
        public int id_compra;

        public List<CarroModel> lista = new List<CarroModel>();

        public Compra()
        {

        }

        public void salvar()
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO Compra (teste_compra) " +
                                             "VALUES ('teste')";

            Conexao.CRUD(command);
        }

        public void gravarCompra()
        {

            foreach (CarroModel carro in lista)
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO pedidocompra (fk_id_carro, fk_id_compra) " +
                                                 "VALUES (@fk_id_carro, @fk_id_compra)";

                command.Parameters.AddWithValue("@fk_id_carro", carro.id);
                command.Parameters.AddWithValue("@fk_id_compra", this.id_compra);
               
                Conexao.CRUD(command);
            }
        }

    
        
        
        
    }
}
