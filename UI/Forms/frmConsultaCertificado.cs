using CRUD;
using DataBase;
using System;
using System.Windows.Forms;

namespace UI
{
   public partial class frmConsultaCertificado : Form
   {
      public frmConsultaCertificado()
      {
         InitializeComponent();
      }
      public string descricao = "", matricula = "", data = "", codigo = "", carga = "", codAluno = "";
      public int atividade = 0, i = 0;

      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         var reader = Localizar.PesquisarCertificado(txbFiltro.Text);

         dgvDados.Rows.Clear();

         try
         {
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
            codAluno = dgvDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            codigo = dgvDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            Close();
         }
      }
   }
}
