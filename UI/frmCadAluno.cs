using Funcoes;
using System;
using System.Windows.Forms;

namespace UI
{
   public partial class frmCadAluno : Form
   {
      public frmCadAluno()
      {
         InitializeComponent();
      }
      private void btnSalvar_Click(object sender, EventArgs e)
      {
         Ferramentas.BuscaCodigo(cobCurso.Text);
      }
   }
}
