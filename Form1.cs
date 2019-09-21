using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPedido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                               

                string constring = "Persist Security Info=False;server=127.0.0.1;port=3306;database=pedido;uid=root;pwd=";
                string Query = "insert into dadospedido (descricao, quantidade, valor, nomecliente, cpf, cnpj, endereco, telefone) values ('" + this.texDesc.Text + "','" + this.texQuantd.Text + "','" + this.texVlrUnit.Text + "', '" + this.texNomeCliente.Text + "','" + this.textCPF.Text + "','" + this.texCNPJ.Text + "', '" + this.texEndereco.Text + "','" + this.texTelefone.Text + "' )";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader MyReader;
                try
                {
                    conDataBase.Open();
                    MyReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Dados Inseridos com Sucesso!");
                    while (MyReader.Read())
                    {

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            texDesc.Text = "";
            texQuantd.Text = "";
            texVlrUnit.Text = "";
            texEndereco.Text = "";
            texTelefone.Text = "";
            texNomeCliente.Text = "";
            textCPF.Text = "";
            texCNPJ.Text = "";
        }

        private void btnPes_Click(object sender, EventArgs e)
        {
            PedidosCadastrados p = new PedidosCadastrados();
            p.Show();
        }

      
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 r = new Form1();
            this.Close();
        }
    }
}
