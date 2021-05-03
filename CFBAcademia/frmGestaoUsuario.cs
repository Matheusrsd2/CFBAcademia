using CFBAcademia.DAL;
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
    public partial class frmGestaoUsuario : Form
    {
        public frmGestaoUsuario()
        {
            InitializeComponent();
        }

        private void frmGestaoUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DALUsuario.ObterUsuarios();
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string id = "";
            DALUsuario.ObterUsuariosById(id);
        }
    }
}
