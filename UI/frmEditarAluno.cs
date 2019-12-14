using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Classes;
using Funcoes;

namespace UI
{
   public partial class frmEditarAluno : Form
   {
      public frmEditarAluno()
      {
         InitializeComponent();
      }

      private void btnPesquisar_Click(object sender, EventArgs e)
      {
         bool filtrarTudo;

         if (txbFiltro.Text == "")
         {
            filtrarTudo = true;
         }
         else
         {
            filtrarTudo = false;
         }

         //dgvAluno.DataSource = Localizar.PesquisarAluno(txbFiltro.Text, filtrarTudo);
         string comando = "";
         OleDbCommand cmd;

         if (filtrarTudo == true)
         {
            comando = "SELECT * FROM tblAlunos";
            cmd = new OleDbCommand(comando);
         }
         else
         {
            comando = "SELECT * FROM tblAlunos WHERE nome LIKE '" + txbFiltro.Text + "%'";
            cmd = new OleDbCommand(comando);
         }

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         //Insância um novo DataTable.
         DataTable dt = new DataTable();

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
               i++;
               
            }
         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);

         }
         finally
         {
            Conexao.Desconectar();

         }

      }
   }
}
