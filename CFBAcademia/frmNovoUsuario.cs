using CFBAcademia.DAL;
using CFBAcademia.Entidades;
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
    public partial class frmNovoUsuario : Form
    {
        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Username = txtUsername.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Status = cbStatus.Text;
            usuario.Nivel = Convert.ToInt32(numNivel.Value);

            DALUsuario dal = new DALUsuario();
            dal.NovoUsuario(usuario);

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtUsername.Clear();
            txtSenha.Clear();
            cbStatus.Text = "";
            numNivel.Value = 1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtUsername.Clear();
            txtSenha.Clear();
            cbStatus.Text = "";
            numNivel.Value = 1;
        }

        private void frmNovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numNivel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
