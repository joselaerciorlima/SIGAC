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
      public string ondeSalvar = "";
      private void btnSalvar_Click(object sender, EventArgs e)
      {
         if (ondeSalvar == "inserir")
         {
            //Busca o método que está dentro da classe 'Ferramentas' e passa o parametro com a combobox.
            int curso = Ferramentas.BuscaCodigoCurso(cobCurso.Text);

            int turma = Ferramentas.BuscaCodigoTurma(cobTurma.Text);

            string data = DateTime.Today.ToString();

            var aluno = new Cadastrar(txbNome.Text, txbMatricula.Text, curso, turma, data);
         }

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

      private void btnNovo_Click(object sender, EventArgs e)
      {
         btnSalvar.Enabled = true;
         btnNovo.Enabled = false;
         btnEditar.Enabled = false;
         btnCancelar.Enabled = true;
         pnlDados.Enabled = true;
         ondeSalvar = "inserir";
      }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
         btnSalvar.Enabled = false;
         btnEditar.Enabled = true;
         btnExcluir.Enabled = false;
         btnNovo.Enabled = true;
         btnCancelar.Enabled = false;
         pnlDados.Enabled = false;
         pnlLista.Enabled = false;
      }
   }
}
