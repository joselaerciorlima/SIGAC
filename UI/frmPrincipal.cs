using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI
{
   public partial class frmPrincipal : Form
   {
      public frmPrincipal()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         var form = new frmCadAluno();
         form.ShowDialog();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         var form = new frmCadAtividade();
         form.ShowDialog();
      }

      private void button3_Click(object sender, EventArgs e)
      {
         var form = new frmCadCertificado();
         form.ShowDialog();
      }

      private void button4_Click(object sender, EventArgs e)
      {
         var form = new frmCadCurso();
         form.ShowDialog();
      }

      private void button5_Click(object sender, EventArgs e)
      {
         var form = new frmEditarAluno();
         form.ShowDialog();
      }

      private void button6_Click(object sender, EventArgs e)
      {
         var form = new frmEditarAtividade();
         form.ShowDialog();
      }

      private void button7_Click(object sender, EventArgs e)
      {
         var form = new frmEditarCertificado();
         form.ShowDialog();
      }

      private void button9_Click(object sender, EventArgs e)
      {
         var form = new frmRelCargaHorariaAluno();
         form.ShowDialog();
      }

      private void button10_Click(object sender, EventArgs e)
      {
         var form = new frmRelCertificadoAluno();
         form.ShowDialog();
      }

      private void button11_Click(object sender, EventArgs e)
      {
         var form = new frmRelResumoAluno();
         form.ShowDialog();
      }
   }
}
