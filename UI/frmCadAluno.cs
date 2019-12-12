using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace SIGAC_Sistema_Gestao_Atividades_Complementares
{
   public partial class CodigoCurso : Form
   {
      public CodigoCurso()
      {
         InitializeComponent();
      }

      private void btnSalvar_Click(object sender, EventArgs e)
      {
         int codCurso = 0;
        
         OleDbConnection conexao = new OleDbConnection();

         conexao.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["caminho_banco"] + "DataBaseSIGAC.mdb";

         //Busca o codigo do curso selecionado
         try
         {
            conexao.Open();

            string comando = "SELECT codCurso,descricaoCurso FROM tblCursos WHERE descricaoCurso = '" + cobCurso.Text + "'";

            OleDbCommand cmd = new OleDbCommand(comando, conexao);

            cmd.ExecuteNonQuery();

            OleDbDataReader reader = cmd.ExecuteReader();

            reader.Read();

            codCurso = (int)reader.GetValue(0);

            reader.Close();
            conexao.Close();

         }
         catch (OleDbException erro)
         {
            MessageBox.Show(erro.ToString());
            conexao.Close();

         }


         try
         {
            conexao.Open();

            string comando = "INSERT INTO tblAlunos (matricula,nome,codCurso,anoTurma) VALUES (@matricula,@nome,@codCurso,@anoTurma)";

            OleDbCommand cmd = new OleDbCommand(comando, conexao);

            cmd.Parameters.Add(new OleDbParameter("@matricula", txbMatricula.Text));
            cmd.Parameters.Add(new OleDbParameter("@nome", txbNome.Text));
            cmd.Parameters.Add(new OleDbParameter("@codCurso", codCurso));
            cmd.Parameters.Add(new OleDbParameter("@anoTurma", cobTurma.Text));

            cmd.ExecuteNonQuery();

            MessageBox.Show("Dados salvos");

         }
         catch (OleDbException erro)
         {
            MessageBox.Show(erro.ToString());
            conexao.Close();

         }


      }

      private void CodigoCurso_Load(object sender, EventArgs e)
      {
         
         //Verifica se já existe o caminho do banco, se não existir ele cria o diretorio.
         if (!System.IO.Directory.Exists(@"C:\SIGAC\Banco de Dados"))
         {
            System.IO.Directory.CreateDirectory(@"C:\SIGAC\Banco de Dados\");
         }

         OleDbConnection conexao = new OleDbConnection();

         conexao.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["caminho_banco"] + "DataBaseSIGAC.mdb";

         //Busca o codigo do curso selecionado

         conexao.Open();

         string comando = "SELECT descricaoCurso FROM tblCursos";

         OleDbCommand cmd = new OleDbCommand(comando, conexao);

         cmd.ExecuteNonQuery();

         OleDbDataReader reader = cmd.ExecuteReader();
       
         DataTable dt = new DataTable();

         dt.Load(reader);
         cobCurso.DisplayMember = "descricaoCurso";

         cobCurso.DataSource = dt;

         reader.Close();
         conexao.Close();

      }

      private void btnSair_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}

