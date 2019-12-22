using DataBase;
using CRUD;
using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Funcoes;

namespace UI
{
   public partial class frmCadAluno : frmModelo
   {
      public frmCadAluno()
      {
         InitializeComponent();
      }
      //========================================================
      public void LimpaTela()
      {
         txbMatricula.Clear();
         txbNome.Clear();
         cobCurso.SelectedIndex = 0;
         cobTurma.SelectedIndex = 0;
         txbCodAluno.Clear();
      }
      //========================================================
      private void frmCadAluno_Load(object sender, EventArgs e)
      {
         alteraBotoes(1);

         //Parâmetro necessário para exibir os valores recuperados no controle combobox.
         cobCurso.DisplayMember = "descricaoCurso";
         //Busca o método que está dentro da classe 'Ferramentas' e retorna o valor para o DataSource do controle combobox.
         cobCurso.DataSource = Ferramentas.PreencheComboBoxCurso();

         cobTurma.DisplayMember = "anoTurma";
         cobTurma.DataSource = Ferramentas.PreencheComboBoxTurma();
      }
      //========================================================
      private void btnNovo_Click(object sender, EventArgs e)
      {
         operacao = "novo";
         alteraBotoes(2);
      }
      //========================================================
      private void btnCancelar_Click(object sender, EventArgs e)
      {
         LimpaTela();
         alteraBotoes(1);
      }
      //========================================================
      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         var form = new frmConsultaAluno();
         form.ShowDialog();

         if (form.codigo != "")
         {
            string curso = Ferramentas.ConverteCurso(form.curso);

            string turma = Ferramentas.ConverteTurma(form.turma);

            txbMatricula.Text = form.matricula.ToString();
            txbNome.Text = form.nome;
            cobCurso.Text = curso;
            cobTurma.Text = turma;
            txbCodAluno.Text = form.codigo;

            alteraBotoes(3);
         }
         else
         {
            LimpaTela();
            alteraBotoes(1);
         }
         form.Dispose();
      }
      //========================================================
      private void btnEditar_Click(object sender, EventArgs e)
      {
         operacao = "alterar";
         alteraBotoes(2);
      }
      //========================================================
      private void btnExcluir_Click(object sender, EventArgs e)
      {
         DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);

         if (d.ToString() == "Yes")
         {
            var excluir = new Excluir(txbCodAluno.Text,txbCodAluno);

            LimpaTela();
            alteraBotoes(1);
         }

      }
      //========================================================
      private void btnSalvar_Click(object sender, EventArgs e)
      {
         if (operacao == "novo")
         {
            int curso = Ferramentas.BuscaCodigoCurso(cobCurso.Text);

            int turma = Ferramentas.BuscaCodigoTurma(cobTurma.Text);

            string data = DateTime.Today.ToString();

            var aluno = new Cadastrar(txbNome.Text, txbMatricula.Text, curso, turma, data);

            LimpaTela();
            alteraBotoes(1);
         }
         else
         {
            int curso = Ferramentas.BuscaCodigoCurso(cobCurso.Text);

            int turma = Ferramentas.BuscaCodigoTurma(cobTurma.Text);

            var data = DateTime.Now.ToString();

            var aluno = new Atualizar(txbCodAluno.Text, txbNome.Text, txbMatricula.Text, curso, turma, data);

            LimpaTela();
            alteraBotoes(1);
         }
      }
      //========================================================
      private void txbMatricula_KeyPress(object sender, KeyPressEventArgs e)
      {
         txbMatricula.MaxLength = 10;
      }
      //========================================================
      private void button5_Click(object sender, EventArgs e)
      {
         Close();
      }
      //========================================================
      private void btnFecharForm_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
