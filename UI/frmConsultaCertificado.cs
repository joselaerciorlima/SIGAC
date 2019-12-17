using Classes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UI
{
   public partial class frmConsultaCertificado : Form
   {
      public frmConsultaCertificado()
      {
         InitializeComponent();
      }
      public string codigo = "";
      public string descricao = "", matricula = "", data = "";
      public string carga ="";
      public int atividade = 0, codAluno = 0;


      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         string comando = "";
         if (txbFiltro.Text != "")
         {
            comando = "SELECT * FROM tblCertificados WHERE matricula LIKE '" + txbFiltro.Text + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblCertificados";
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
               dgvDados.Rows[i].Cells["clnDescricao"].Value = reader["descricaoCertificado"];
               dgvDados.Rows[i].Cells["clnData"].Value = reader["dataCertificado"];
               dgvDados.Rows[i].Cells["clnClassificacao"].Value = reader["codAtividade"];
               dgvDados.Rows[i].Cells["clnCarga"].Value = reader["cargaHorariaCertificado"];
               dgvDados.Rows[i].Cells["clnCodAluno"].Value = reader["codAluno"];
               dgvDados.Rows[i].Cells["clnCodigo"].Value = reader["codCertificado"];
               i++;
            }
         }
         catch (Exception erro)
         { MessageBox.Show(erro.Message); }
         finally
         { Conexao.Desconectar(); }
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
            descricao = dgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            data = dgvDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            atividade = (int)dgvDados.Rows[e.RowIndex].Cells[3].Value;
            carga = dgvDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            codAluno = (int)dgvDados.Rows[e.RowIndex].Cells[5].Value;
            codigo = dgvDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            Close();

         }
      }
   }
}
