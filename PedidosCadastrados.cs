using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CadastroPedido
{
    public partial class PedidosCadastrados : Form
    {
        SqlConnection conexao = new SqlConnection("Persist Security Info = False; server=127.0.0.1;database=pedido;uid=root;pwd=");
        SqlCommand cmd;
     
      
        int ID = 0;



        public PedidosCadastrados()
        {
            InitializeComponent();

            Conexao conexao = new Conexao(); 
          
        }

     
            private void button2_Click(object sender, EventArgs e)
        {
            PedidosCadastrados f = new PedidosCadastrados();
            this.Close();
        }
        
        private void PedidosCadastrados_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                
                string strSql = "select * from dadospedido";
              
                SqlConnection con = new SqlConnection("Persist Security Info = False; server=127.0.0.1;database=pedido;uid=root;pwd=");
               
                SqlCommand cmd = new SqlCommand(strSql, con);
              
                con.Open();
               
                cmd.CommandType = CommandType.Text;
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               
                DataTable pedidos = new DataTable();
               
                da.Fill(pedidos);
              
                mostradados.DataSource = pedidos;
            }

                ID = Convert.ToInt32(mostradados.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBox1.Text = mostradados.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = mostradados.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox3.Text = mostradados.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox4.Text = mostradados.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox5.Text = mostradados.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox6.Text = mostradados.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox7.Text = mostradados.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox8.Text = mostradados.Rows[e.RowIndex].Cells[8].Value.ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            {
                if (ID != 0)
                {
                    cmd = new SqlCommand("delete dadospedido where ID=@id", conexao);
                    conexao.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Dados removidos!");
                   
                }
                else
                {
                    MessageBox.Show("Selecione dado para deletar");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    cmd = new SqlCommand("update dadospedido set descricao=@descricao, quantidade=@quantidade, valor=@valor,nomecliente=@nomecliente,cpf=@cpf,cnpj=@cnpj,endereco=@endereco,telefone=@telefone, where ID=@id", conexao);
                    conexao.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@descricao", textBox1.Text);
                    cmd.Parameters.AddWithValue("@quantidade", textBox2.Text);
                    cmd.Parameters.AddWithValue("@valor", textBox3.Text);
                    cmd.Parameters.AddWithValue("@nomecliente", textBox4.Text);
                    cmd.Parameters.AddWithValue("@cpf", textBox5.Text);
                    cmd.Parameters.AddWithValue("@cnpj", textBox6.Text);
                    cmd.Parameters.AddWithValue("@endereco", textBox7.Text);
                    cmd.Parameters.AddWithValue("@telefone", textBox8.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados atualizados com sucesso!");
                    conexao.Close();
                 
                }
                else
                {
                    MessageBox.Show("Selecione a celular para gravar");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
           
        
