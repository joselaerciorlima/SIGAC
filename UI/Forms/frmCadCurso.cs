using DataBase;
using CRUD;
using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Funcoes;

namespace UI
{
   public partial class frmCadCurso : frmModelo
   {
      public frmCadCurso()
      {
         InitializeComponent();
      }
      //=========================================================
      public void LimpaTela()
      {
         txbDescricao.Clear();
         txbCodCurso.Clear();
         cobPeriodo.SelectedIndex = 0;
      }
      //=========================================================
      private void frmCadCurso_Load(object sender, EventArgs e)
      {
         alteraBotoes(1);

         cobPeriodo.DisplayMember = "descricaoPeriodo";
         cobPeriodo.DataSource = Ferramentas.PreencheComboBoxPeriodo();
      }
      //=========================================================
      private void btnNovo_Click(object sender, EventArgs e)
      {
         operacao = "novo";
         alteraBotoes(2);
      }
      //=========================================================
      private void btnCancelar_Click(object sender, EventArgs e)
      {
         LimpaTela();
         alteraBotoes(1);
      }
      //=========================================================
      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         var form = new frmConsultaCurso();
         form.ShowDialog();

         if (form.codigo != "")
         {
            string periodo = Ferramentas.ConvertePeriodo(form.periodo);

            txbDescricao.Text = form.descricao;
            txbCodCurso.Text = form.codigo;
            cobPeriodo.Text = periodo;

            alteraBotoes(3);
         }
         else
         {
            LimpaTela();
            alteraBotoes(1);
         }
         form.Dispose();
      }
      //=========================================================
      private void btnEditar_Click(object sender, EventArgs e)
      {
         operacao = "alterar";
         alteraBotoes(2);
      }
      //=========================================================
      private void btnExcluir_Click(object sender, EventArgs e)
      {
         DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
         if (d.ToString() == "Yes")
         {
            var excluir = new Excluir(txbCodCurso.Text, txbCodCurso);

            LimpaTela();
            alteraBotoes(1);
         }
      }
      //=========================================================
      private void btnSalvar_Click(object sender, EventArgs e)
      {
         if (operacao == "novo")
         {
            int periodo = Ferramentas.BuscaCodigoPeriodo(cobPeriodo.Text);

            string data = DateTime.Today.ToString();

            var curso = new Cadastrar(txbDescricao.Text, periodo, data);

            LimpaTela();
            alteraBotoes(1);
         }
         else
         {
            int periodo = Ferramentas.BuscaCodigoPeriodo(cobPeriodo.Text);

            var data = DateTime.Now.ToString();

            var curso = new Atualizar(txbCodCurso.Text, txbDescricao.Text, periodo, data);

            LimpaTela();
            alteraBotoes(1);
         }
      }
      //=========================================================
      private void btnFecharForm_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
