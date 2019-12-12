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
         //Busca o método que está dentro da classe 'Ferramentas' e passa o parametro com a combobox.
         int curso = Ferramentas.BuscaCodigoCurso(cobCurso.Text);

         int turma = Ferramentas.BuscaCodigoTurma(cobTurma.Text);

         string data = DateTime.Today.ToString();

         var aluno = new Cadastrar(txbNome.Text, txbMatricula.Text, curso, turma, data);
      }

      private void frmCadAluno_Load(object sender, EventArgs e)
      {
         //Parâmetro necessário para exibir os valores recuperados no controle combobox.
         cobCurso.DisplayMember = "descricaoCurso";
         //Busca o método que está dentro da classe 'Ferramentas' e retorna o valor para o DataSource do controle combobox.
         cobCurso.DataSource = Ferramentas.PreencheComboBoxCurso();

         cobTurma.DisplayMember = "anoTurma";
         cobTurma.DataSource = Ferramentas.PreencheComboBoxTurma();
      }

      private void btnSair_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
