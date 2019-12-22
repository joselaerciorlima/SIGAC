using DataBase;
using CRUD;
using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Funcoes;

namespace UI
{
   public partial class frmCadCertificado : frmModelo
   {
      public frmCadCertificado()
      {
         InitializeComponent();
      }
      //=========================================================
      public void LimpaTela()
      {
         txbCodCertificado.Clear();
         txbMatricula.Clear();
         txbNome.Clear();
         txbDescricao.Clear();
         txbCargaHoraria.Clear();
         txbData.Clear();
         cobClassificacao.SelectedIndex = 0;
      }
      //=========================================================
      private void frmCadAtividade_Load(object sender, EventArgs e)
      {
         alteraBotoes(1);

         cobClassificacao.DisplayMember = "descricaoAtividade";
         cobClassificacao.DataSource = Ferramentas.PreencheComboBoxAtividade();
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
         var form = new frmConsultaCertificado();
         form.ShowDialog();

         if (form.codigo != "")
         {
            string atividade = Ferramentas.ConverteAtividade(form.atividade);

            string aluno = Ferramentas.ConverteAluno(Convert.ToInt32(form.codAluno));

            txbCodCertificado.Text = form.codigo;
            txbMatricula.Text = form.matricula;
            txbNome.Text = aluno;
            txbDescricao.Text = form.descricao;
            txbCargaHoraria.Text = form.carga;
            txbData.Text = form.data;
            cobClassificacao.Text = atividade;
            txbCodAluno.Text = form.codAluno.ToString();

            alteraBotoes(3);
         }
         else
         {
            LimpaTela();
            alteraBotoes(1);
            return;

         }
         form.Dispose();
      }
      //=========================================================
      private void btnEditar_Click(object sender, EventArgs e)
      {
         operacao = "alterar";
         alteraBotoes(2);
         txbMatricula.Enabled = false;
      }
      //=========================================================
      private void btnExcluir_Click(object sender, EventArgs e)
      {

         DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
         if (d.ToString() == "Yes")
         {

            var excluir = new Excluir(txbCodCertificado.Text, txbCodCertificado);

            LimpaTela();
            alteraBotoes(1);

         }
      }
      //=========================================================
      private void btnSalvar_Click(object sender, EventArgs e)
      {
         if (operacao == "novo")
         {
            int classificacao = Ferramentas.BuscaCodigoAtividade(cobClassificacao.Text);

            string data = DateTime.Today.ToString();

            var certificado = new Cadastrar(txbMatricula.Text, txbCodAluno.Text, txbData.Text, txbDescricao.Text, classificacao, txbCargaHoraria.Text, data);

            LimpaTela();
            alteraBotoes(1);
         }
         else
         {

            int classificacao = Ferramentas.BuscaCodigoAtividade(cobClassificacao.Text);

            var data = DateTime.Now.ToString();

            var certificado = new Atualizar(txbCodCertificado.Text, txbMatricula.Text, txbCodAluno.Text, txbDescricao.Text, txbCargaHoraria.Text, txbData.Text, classificacao, data);

            LimpaTela();
            alteraBotoes(1);
         }
      }
      //=========================================================
      private void btnPesquisarAluno_Click(object sender, EventArgs e)
      {
         var form = new frmConsultaAluno();
         form.ShowDialog();

         if (form.codigo != "")
         {

            txbMatricula.Text = form.matricula.ToString();
            txbNome.Text = form.nome;
            txbCodAluno.Text = form.codigo;
            txbData.Focus();
         }
         else
         {
            MessageBox.Show("Selecione um aluno cadastrado para continuar!");
            form.Dispose();
            return;
         }

         form.Dispose();
      }
      //=========================================================
      private void btnFecharForm_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
