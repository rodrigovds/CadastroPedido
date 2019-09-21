using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPedido
{
    class Conexao
    {
        const string connection = @"Data Source=pedido;Initial Catalog=dadospedido;Integrated Security=True";
        public SqlConnection conexao()
        {
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}
