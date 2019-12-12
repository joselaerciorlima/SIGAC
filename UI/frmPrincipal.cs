using System;
using System.Windows.Forms;

namespace UI
{
   public partial class frmPrincipal : Form
   {
      public frmPrincipal()
      {
         InitializeComponent();
      }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         var form = new frmCadAluno();
         form.ShowDialog();
        }

        private void atividadeComplementarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         var form = new frmCadAtividade();
         form.ShowDialog();
      }

      private void sairToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         var form = new frmCadCurso();
         form.ShowDialog();
      }

        private void certificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         var form = new frmCadCertificado();
         form.ShowDialog();
      }
    }
}
