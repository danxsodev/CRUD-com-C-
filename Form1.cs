using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tela_de_login
{
    public partial class tela_de_login : Form
    {
        public tela_de_login()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"data source=LAB1-19;integrated Security=false;initial catalog=db_turmaA;user id=sa; password=1234567");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Favor informar o código do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_id.Focus();
            }
            else if (textBox_func.Text == "")
            {
                MessageBox.Show("Favor informar o nome do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_func.Focus();
            }
            else if (textBox_func.Text.Length < 8)
            {
                MessageBox.Show("Favor informar o nome completo do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_func.Focus();
            }
            else
            {
                int vId = Convert.ToInt32(textBox_id.Text);
                string vFuncionario = textBox_func.Text;
                string vCPF = textBox_cpf.Text;


                try
                {
                    string sql = "select id_func from funcionario where id_func =" + vId;
                    cn.Open();
                    cm.Connection = cn;
                    cm.CommandText = sql;
                    dt = cm.ExecuteReader();

                    if (dt.HasRows)
                    {
                        MessageBox.Show("Este código já está sendo usado por um funcionário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_id.Focus();
                        cn.Close();
                    }

                    else
                    {
                        if (!dt.IsClosed) { dt.Close(); }
                        sql = "insert into funcionario(id_func, no_cpf,nm_func) values (@Cod, @CPF,@Func)";
                        cm.Parameters.Add("@Cod", SqlDbType.Int).Value = vId;
                        cm.Parameters.Add("@Func", SqlDbType.VarChar).Value = vFuncionario;
                        cm.Parameters.Add("@CPF", SqlDbType.Char).Value = vCPF;
                        cm.Connection = cn;
                        cm.CommandText = sql;
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso", "Registros inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_excluir();
                        textBox_id.Focus();
                        cn.Close();
                    }
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }


        }
        private void btn_excluir()
        {
            textBox_id.Text = "";
            textBox_func.Text = "";
            textBox_cpf.Text = "";
        }



        private void tela_de_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int vId = Convert.ToInt32(textBox_id.Text);
            string vFuncionario = textBox_func.Text;
            string vCPF = textBox_cpf.Text;

            try
            {
                string sql = "select * from funcionario where id_func=" + vId;
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = sql;
                dt = cm.ExecuteReader();

                if (!dt.HasRows)
                {
                    MessageBox.Show("Este código não está sendo usado por um funcionário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_id.Focus();
                    cn.Close();
                }

                else
                {
                    dt.Read();
                    textBox_func.Text = dt["nm_func"].ToString();
                    textBox_cpf.Text = dt["no_cpf"].ToString();
                    cn.Close();
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            btn_excluir();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            int vId = Convert.ToInt32(textBox_id.Text);
            string vFuncionario = textBox_func.Text;
            string vCPF = textBox_cpf.Text;

            try
            {
                string sql = "select * from funcionario where id_func=" + vId;
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = sql;
                dt = cm.ExecuteReader();

                if (!dt.HasRows)
                {
                    MessageBox.Show("Este código não está sendo usado por um funcionário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_id.Focus();
                    cn.Close();
                }




            }
        }
    }
}


