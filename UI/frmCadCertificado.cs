using Funcoes;
using System;
using System.Windows.Forms;

namespace UI
{
   public partial class frmCadCertificado : Form
   {
      public frmCadCertificado()
      {
         InitializeComponent();
      }

        private void frmCadCertificado_Load(object sender, EventArgs e)
        {
         cobClassificacao.DisplayMember = "descricaoAtividade";
         cobClassificacao.DataSource = Ferramentas.PreencheComboBoxAtividade();
        }

      private void btnSalvar_Click(object sender, EventArgs e)
      {
         int codigo = Ferramentas.BuscaCodigoAtividade(cobClassificacao.Text);

         var certificado = new Cadastrar(txbMatricula.Text, txbData.Text, txbDescricao.Text, codigo, txbCargaHoraria.Text);

      }

      private void btnSair_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
