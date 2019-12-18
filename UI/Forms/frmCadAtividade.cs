using Classes;
using Funcoes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UI
{
   public partial class frmCadAtividade : frmModelo
   {
      public frmCadAtividade()
      {
         InitializeComponent();
      }
      public void LimpaTela()
      {
         txbDescricao.Clear();
         txbCargaHoraria.Clear();
         cobGrupo.SelectedIndex = 0;
         txbCodAtividade.Clear();
      }
      private void frmCadAtividade_Load(object sender, EventArgs e)
      {
         alteraBotoes(1);

         cobGrupo.DisplayMember = "descricaoGrupo";
         cobGrupo.DataSource = Ferramentas.PreencheComboBoxGrupo();
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
         var form = new frmConsultaAtividade();
         form.ShowDialog();
         //form.Dispose();

         if (form.codigo != "")
         {
            string grupo = Ferramentas.ConverteGrupo(form.grupo);

            txbDescricao.Text = form.descricao;
            txbCargaHoraria.Text = form.cargaHoraria;
            cobGrupo.Text = grupo;
            txbCodAtividade.Text = form.codigo;

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
               var cmd = new OleDbCommand("DELETE FROM tblAtividades WHERE codAtividade = @codigo");

               cmd.Parameters.AddWithValue("@codigo", txbCodAtividade.Text);

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
            int grupo = Ferramentas.BuscaCodigoGrupo(cobGrupo.Text);

            string data = DateTime.Today.ToString();

            var atividade = new Cadastrar(txbDescricao.Text, txbCargaHoraria.Text, grupo,data);

            LimpaTela();
            alteraBotoes(1);
         }
         else
         {

            int grupo = Ferramentas.BuscaCodigoGrupo(cobGrupo.Text);

            var data = DateTime.Now.ToString();

            var aluno = new Atualizar(txbCodAtividade.Text, txbDescricao.Text, txbCargaHoraria.Text, grupo, data);

            LimpaTela();
            alteraBotoes(1);
         }
      }

   }
}
