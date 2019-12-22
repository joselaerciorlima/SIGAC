using DataBase;
using CRUD;
using System;
using System.Windows.Forms;

namespace UI
{
   public partial class frmConsultaAtividade : Form
   {
      public frmConsultaAtividade()
      {
         InitializeComponent();
      }
      public string descricao = "", codigo = "", cargaHoraria = "";
      public int grupo = 0, i = 0;

      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         var reader = Localizar.PesquisarAtividade(txbFiltro.Text);

         dgvDados.Rows.Clear();

         try
         {
            while (reader.Read())
            {
               dgvDados.Rows.Add();
               dgvDados.Rows[i].Cells["clnDescricao"].Value = reader["descricaoAtividade"];
               dgvDados.Rows[i].Cells["clnCarga"].Value = reader["cargaHorariaAtividade"];
               dgvDados.Rows[i].Cells["clnGrupo"].Value = reader["codGrupo"];
               dgvDados.Rows[i].Cells["clnCodigo"].Value = reader["codAtividade"];
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
            cargaHoraria = dgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            grupo = (int)dgvDados.Rows[e.RowIndex].Cells[2].Value;
            codigo = dgvDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            Close();
         }
      }
   }
}
