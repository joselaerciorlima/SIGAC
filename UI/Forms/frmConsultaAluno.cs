using DataBase;
using System;
using System.Windows.Forms;
using CRUD;

namespace UI
{
   public partial class frmConsultaAluno : Form
   {
      public frmConsultaAluno()
      {
         InitializeComponent();
      }
      public string codigo = "", nome = "", matricula = "";
      public int curso = 0, turma = 0, i = 0;

      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         var reader = Localizar.PesquisarAluno(txbFiltro.Text, rbMatricula, rbNome);

         dgvDados.Rows.Clear();

         try
         {
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
