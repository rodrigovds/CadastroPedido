using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPedido
{
     public class Pedido
    {

        public int Id = 0;
        public string Descricao { get; set; }
        public string Quantidade { get; set; }
        public string Valor { get; set; }
        public string NomeCliente { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        }
        
}     

