using Funcoes;
using System;
using System.Windows.Forms;

namespace UI
{
   public partial class frmCadAtividade : Form
   {
      public frmCadAtividade()
      {
         InitializeComponent();
      }

        private void frmCadAtividade_Load(object sender, EventArgs e)
        {
         cobGrupo.DisplayMember = "descricaoGrupo";
         cobGrupo.DataSource = Ferramentas.PreencheComboBoxGrupo();
      }

      private void btnSalvar_Click(object sender, EventArgs e)
      {
         int grupo = Ferramentas.BuscaCodigoGrupo(cobGrupo.Text);

         var atividade = new Cadastrar(txbDescricao.Text,txbCargaHoraria.Text, grupo);
      }

      private void btnSair_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
