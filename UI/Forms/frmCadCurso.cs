using Classes;
using Funcoes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UI
{
   public partial class frmCadCurso : frmModelo
   {
      public frmCadCurso()
      {
         InitializeComponent();
      }
      public void LimpaTela()
      {
         txbDescricao.Clear();
         txbCodCurso.Clear();
         cobPeriodo.SelectedIndex = 0;
      }
      private void frmCadCurso_Load(object sender, EventArgs e)
      {
         alteraBotoes(1);

         cobPeriodo.DisplayMember = "descricaoPeriodo";
         cobPeriodo.DataSource = Ferramentas.PreencheComboBoxPeriodo();
      }
      private void btnNovo_Click(object sender, EventArgs e)
      {
         operacao = "novo";
         alteraBotoes(2);
      }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
         LimpaTela();
         alteraBotoes(1);
      }

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

      private void btnEditar_Click(object sender, EventArgs e)
      {
         operacao = "alterar";
         alteraBotoes(2);
      }

      private void btnExcluir_Click(object sender, EventArgs e)
      {
         try
         {
            DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
            if (d.ToString() == "Yes")
            {
               var cmd = new OleDbCommand("DELETE FROM tblCursos WHERE codCurso = @codigo");

               cmd.Parameters.AddWithValue("@codigo", txbCodCurso.Text);

               cmd.Connection = Conexao.connection;

               Conexao.Conectar();
               cmd.ExecuteNonQuery();
               LimpaTela();
               alteraBotoes(1);

            }
         }
         catch
         {
            MessageBox.Show("Impossivel excluir o registro. \n O registro está sendo utilizado em outro local.");
            alteraBotoes(3);
         }
         finally
         {
            Conexao.Desconectar();
         }
      }

      private void btnSalvar_Click(object sender, EventArgs e)
      {
         if (operacao == "novo")
         {
            //Busca o método que está dentro da classe 'Ferramentas' e passa o parametro com a combobox.
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
      private void btnFecharForm_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
