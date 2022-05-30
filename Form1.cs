using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tela_de_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"data source=LAB1-19;integrated Security=false;initial catalog=bd_turmaA;user id=sa; password=1234567");
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
            else if (textBox_func.Text.Length <8)
            {
                MessageBox.Show("Favor informar o nome completo do funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_func.Focus();
            }
        }
    }
}
