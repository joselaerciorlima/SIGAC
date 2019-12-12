using System;
using System.Windows.Forms;
using Funcoes;

namespace UI
{
   public partial class frmCadCurso : Form
   {
      public frmCadCurso()
      {
         InitializeComponent();
      }

      private void frmCadCurso_Load(object sender, EventArgs e)
      {
         cobPeriodo.DisplayMember = "descricaoPeriodo";
         cobPeriodo.DataSource = Ferramentas.PreencheComboBoxPeriodo();
      }

      private void btnSalvar_Click(object sender, EventArgs e)
      {
         int codigo = Ferramentas.BuscaCodigoPeriodo(cobPeriodo.Text);

         var curso = new Cadastrar(txbDescricao.Text, codigo);
      }

      private void btnSair_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
