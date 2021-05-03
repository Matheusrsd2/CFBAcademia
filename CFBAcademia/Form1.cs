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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frmLogin f = new frmLogin(this);
            f.ShowDialog();
            //frmTeste f = new frmTeste();
            //f.ShowDialog();


        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {

            }
            else
            {
                MessageBox.Show("É necessário ter um usuario logado");
            }
        }

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel > 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("Esse Usuario nao possui permissao para acessar");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuario logado");
            }
            
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel > 1)
                {
                    frmNovoUsuario f = new frmNovoUsuario();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Esse Usuario nao possui permissao para acessar");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuario logado");
            }
            
        }

        private void gestãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado == true)
            {
                if (Globais.nivel > 1)
                {
                    frmGestaoUsuario f = new frmGestaoUsuario();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Esse Usuario nao possui permissao para acessar");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuario logado");
            }
        }
    }
}
