using Classes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UI
{
   public partial class frmConsultaAluno : Form
   {
      public frmConsultaAluno()
      {
         InitializeComponent();
      }
      public string codigo = "";
      public string nome = "", matricula = "";
      public int curso = 0;
      public int turma = 0;

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
         string comando = "";
         if (rbMatricula.Checked == true)
         {
            comando = "SELECT * FROM tblAlunos WHERE matricula LIKE '" + txbFiltro.Text + "%'";
         }
         else if (rbNome.Checked == true)
         {
            comando = "SELECT * FROM tblAlunos WHERE nome LIKE '" + txbFiltro.Text + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblAlunos";
         }

         var cmd = new OleDbCommand(comando);

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         try
         {
            var reader = cmd.ExecuteReader();
            int i = 0;
            dgvDados.Rows.Clear();

            while (reader.Read())
            {
               dgvDados.Rows.Add();
               dgvDados.Rows[i].Cells["clnMatricula"].Value = reader["matricula"];
               dgvDados.Rows[i].Cells["clnNome"].Value = reader["nome"];
               dgvDados.Rows[i].Cells["clnCurso"].Value = reader["codCurso"];
               dgvDados.Rows[i].Cells["clnTurma"].Value = reader["codTurma"];
               dgvDados.Rows[i].Cells["clnCodigo"].Value = reader["codAluno"];
               i++;
            }
         }
         catch (Exception erro)
         { MessageBox.Show(erro.Message); }
         finally
         { Conexao.Desconectar(); }
      }

      private void rbMatricula_CheckedChanged(object sender, EventArgs e)
      {
         txbFiltro.Clear();
         btnLocalizar_Click(sender, e);
      }

      private void rbNome_CheckedChanged(object sender, EventArgs e)
      {
         txbFiltro.Clear();
         btnLocalizar_Click(sender, e);
      }

      private void frmConsultaAluno_Load(object sender, EventArgs e)
      {
         btnLocalizar_Click(sender, e);
      }

      private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex >= 0)
         {
            matricula = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            nome = dgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            curso = (int)dgvDados.Rows[e.RowIndex].Cells[2].Value;
            turma = (int)dgvDados.Rows[e.RowIndex].Cells[3].Value;
            codigo = dgvDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            Close();
         }
      }
    }
}
