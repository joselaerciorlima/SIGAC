using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
   public partial class frmConsultaAtividade : Form
   {
      public frmConsultaAtividade()
      {
         InitializeComponent();
      }
      public string codigo = "";
      public string descricao = "";
      public string cargaHoraria = "";
      public int grupo = 0;

      private void btnLocalizar_Click(object sender, EventArgs e)
      {
         string comando = "";
         if (txbFiltro.Text != "")
         {
            comando = "SELECT * FROM tblAtividades WHERE descricaoAtividade LIKE '" + txbFiltro.Text + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblAtividades";
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
