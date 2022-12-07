using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcosCurso
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Alunos a = (Alunos)dataGridView1.SelectedRows[0].DataBoundItem;

            txb_NomeAluno.Text = a.Nome;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();

            //List<Alunos> lista = new List<Alunos>();

            //Alunos a = new Alunos();
            //a.IDAlunos = 10;
            //a.Nome = "oko";

            //lista.Add(a); // insere dados no grid principal

            //Alunos b = new Alunos();
            //a.IDAlunos = 11;
            //a.Nome = "kerlo";

            //lista.Add(b);

            //dataGridView1.DataSource = lista;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //int ff = 10;
            //string gg = "kok";

            using(SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=.;Initial Catalog=Escola;User id=sa;Password=Sql@ge1971;";
                con.Open();

                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = con;
                //cmd.CommandText = "insert into alunos (nome,cpf,datanascimento,senha) values (@Nome,@CPF,getdate(),@Senha)";

                //cmd.Parameters.AddWithValue("@Nome", txb_NomeAluno.Text);
                //cmd.Parameters.AddWithValue("@CPF", txb_Cpf.Text);
                //cmd.Parameters.AddWithValue("@Senha", txb_Senha.Text);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into alunos (nome,cpf,datanascimento,senha) values ('" + txb_NomeAluno.Text + "',@CPF,getdate(),@Senha)";

                cmd.Parameters.AddWithValue("@CPF", txb_Cpf.Text);
                cmd.Parameters.AddWithValue("@Senha", txb_Senha.Text);

                cmd.ExecuteNonQuery();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=.;Initial Catalog=Escola;User id=sa;Password=Sql@ge1971;";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Alunos";

                SqlDataReader reader = cmd.ExecuteReader();

                List<Alunos> lista = new List<Alunos>();

                while(reader.Read())
                {
                    Alunos a = new Alunos();
                    a.IDAlunos = Convert.ToInt32(reader["IdAluno"]);
                    a.Nome = reader["Nome"].ToString();

                    lista.Add(a);
                }

                dataGridView1.DataSource = lista;
            }
        }
    }

    public class Alunos
    {
        public int IDAlunos { get; set; }

        public string Nome { get; set; }
    }
}
