using Classes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UI
{
   public partial class frmConsultaCurso : Form
   {
      public frmConsultaCurso()
      {
         InitializeComponent();
      }
      public string codigo = "";
      public string descricao = "";
      public int periodo = 0;

      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         string comando = "";
         if (txbFiltro.Text != "")
         {
            comando = "SELECT * FROM tblCursos WHERE descricaoCurso LIKE '" + txbFiltro.Text + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblCursos";
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
               dgvDados.Rows[i].Cells["clnDescricao"].Value = reader["descricaoCurso"];
               dgvDados.Rows[i].Cells["clnPeriodo"].Value = reader["codPeriodo"];
               dgvDados.Rows[i].Cells["clnCodigo"].Value = reader["codCurso"];
               i++;
            }
         }
         catch (Exception erro)
         { MessageBox.Show(erro.Message); }
         finally
         { Conexao.Desconectar(); }
      }
      private void frmConsultaAtividade_Load(object sender, EventArgs e)
      {
         btnLocalizar_Click(sender, e);
      }

      private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex >= 0)
         {
            descricao = dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            periodo = (int)dgvDados.Rows[e.RowIndex].Cells[1].Value;
            codigo = dgvDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            Close();
         }
      }
   }
}
