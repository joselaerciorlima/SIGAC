using Classes;
using Funcoes;
using System;
using System.Data;
using System.Data.OleDb;
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
         dgvAluno.Rows.Clear();
      }

      private void btnEditar_Click(object sender, EventArgs e)
      {
         btnSalvar.Enabled = true;
         btnNovo.Enabled = false;
         btnCancelar.Enabled = true;
         pnlDados.Enabled = true;
         pnlLista.Enabled = true;         
         ondeSalvar = "atualizar";
      }

      private void btnPesquisar_Click(object sender, EventArgs e)
      {

         if (ondeSalvar == "atualizar")
         {
            string comando = "SELECT * FROM tblAlunos WHERE matricula LIKE '" + txbFiltro.Text + "%'";

            var cmd = new OleDbCommand(comando);

            cmd.Connection = Conexao.connection;

            Conexao.Conectar();

            try
            {
               var reader = cmd.ExecuteReader();
               int i = 0;
               dgvAluno.Rows.Clear();

               while (reader.Read())
               {
                  dgvAluno.Rows.Add();
                  dgvAluno.Rows[i].Cells["clnMatricula"].Value = reader["matricula"];
                  dgvAluno.Rows[i].Cells["clnNome"].Value = reader["nome"];
                  dgvAluno.Rows[i].Cells["clnCurso"].Value = reader["codCurso"];
                  dgvAluno.Rows[i].Cells["clnTurma"].Value = reader["codTurma"];
                  i++;
               }
            }
            catch (Exception erro)
            { MessageBox.Show(erro.Message);}
            finally
            { Conexao.Desconectar();}
         }
      }

      private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         txbMatricula.Text = dgvAluno.SelectedCells[0].Value.ToString();
         txbNome.Text = dgvAluno.SelectedCells[1].Value.ToString();
         cobCurso.Text = dgvAluno.SelectedCells[2].Value.ToString();
         cobTurma.Text = dgvAluno.SelectedCells[3].Value.ToString();
      }

      private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}
