using CRUD;
using System;
using System.Windows.Forms;
using Funcoes;

namespace UI
{
   public partial class frmCadAtividade : frmModelo
   {
      public frmCadAtividade()
      {
         InitializeComponent();
      }
      //=========================================================
      public void LimpaTela()
      {
         txbDescricao.Clear();
         txbCargaHoraria.Clear();
         cobGrupo.SelectedIndex = 0;
         txbCodAtividade.Clear();
      }
      //=========================================================
      private void frmCadAtividade_Load(object sender, EventArgs e)
      {
         alteraBotoes(1);

         cobGrupo.DisplayMember = "descricaoGrupo";
         cobGrupo.DataSource = Ferramentas.PreencheComboBoxGrupo();
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
         var form = new frmConsultaAtividade();
         form.ShowDialog();
        
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
            var excluir = new Excluir(txbCodAtividade.Text,txbCodAtividade);

            LimpaTela();
            alteraBotoes(1);
         }
      }
      //=========================================================
      private void btnSalvar_Click(object sender, EventArgs e)
      {
         if (operacao == "novo")
         {
            //Busca o método que está dentro da classe 'Ferramentas' e passa o parametro com a combobox.
            int grupo = Ferramentas.BuscaCodigoGrupo(cobGrupo.Text);

            string data = DateTime.Today.ToString();

            var atividade = new Cadastrar(txbDescricao.Text, txbCargaHoraria.Text, grupo, data);

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
      //=========================================================
      private void btnFecharForm_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
