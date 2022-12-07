using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcosCurso
{
    public partial class frm_Curso : Form
    {
        public frm_Curso()
        {
            InitializeComponent();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cadastro cadastro = new frm_Cadastro();
            cadastro.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
