using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFBAcademia
{
    public partial class frmLogin : Form
    {
        Form1 form1;
        DataTable dt;
        public frmLogin(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (username == null || senha == null)
            {
                MessageBox.Show("Informe o usuario e a senha");
                txtUsuario.Focus();
                return;
            }

            string sql = "SELECT * FROM Usuarios where username = '"+username+"' AND senha = '"+senha+"' ";
            dt = Banco.Consultar(sql);

            if (dt.Rows.Count == 1)
            {
                form1.label1.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.label2.Text = dt.Rows[0].Field<string>("Nome");
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("Nivel").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario nao encontrado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
