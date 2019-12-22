using DataBase;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Funcoes
{
   public class Ferramentas
   {
      //================ Métodos para localizar =================
      //=========================================================
      public static int BuscaCodigoCurso(string curso)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblCursos WHERE descricaoCurso = @curso");

         cmd.Parameters.AddWithValue("@curso", curso);

         cmd.Connection = Conexao.connection;
        
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            codigo = (int)reader["codCurso"];
        
         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return codigo;
      }
      //=========================================================
      public static int BuscaCodigoTurma(string anoTurma)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAnoTurmas WHERE anoTurma = @turma");

         cmd.Parameters.AddWithValue("@turma", anoTurma);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            codigo = (int)reader["codTurma"];

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return codigo;
      }
      //=========================================================
      public static int BuscaCodigoGrupo(string grupo)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblGrupos WHERE descricaoGrupo = @grupo");

         cmd.Parameters.AddWithValue("@grupo", grupo);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            codigo = (int)reader["codGrupo"];

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return codigo;
      }
      //=========================================================
      public static int BuscaCodigoPeriodo(string periodo)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblPeriodos WHERE descricaoPeriodo = @periodo");

         cmd.Parameters.AddWithValue("@periodo", periodo);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            codigo = (int)reader["codPeriodo"];

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return codigo;
      }
      //=========================================================
      public static int BuscaCodigoAtividade(string atividade)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAtividades WHERE descricaoAtividade = @atividade");

         cmd.Parameters.AddWithValue("@atividade", atividade);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            codigo = (int)reader["codAtividade"];

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return codigo;
      }
      //=========================================================
      public static int BuscaCodigoAluno(string matricula)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAlunos WHERE matricula = @matricula");

         cmd.Parameters.AddWithValue("@matricula", matricula);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            codigo = (int)reader["codAluno"];
         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return codigo;
      }
      //================= Métodos de conversão ==================
      //=========================================================
      public static string ConverteCurso(int curso)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblCursos WHERE codCurso = @curso");

         cmd.Parameters.AddWithValue("@curso", curso);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            descricao = reader["descricaoCurso"].ToString();

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return descricao;
      }
      //=========================================================
      public static string ConverteTurma(int anoTurma)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAnoTurmas WHERE codTurma = @turma");

         cmd.Parameters.AddWithValue("@turma", anoTurma);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            descricao = reader["anoTurma"].ToString();

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         return descricao;
      }
      //=========================================================
      public static string ConverteGrupo(int grupo)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblGrupos WHERE codGrupo = @grupo");

         cmd.Parameters.AddWithValue("@grupo", grupo);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
           
            descricao = reader["descricaoGrupo"].ToString();

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         
         return descricao;
      }
      //=========================================================
      public static string ConverteAtividade(int atividade)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAtividades WHERE codAtividade = @atividade");

         cmd.Parameters.AddWithValue("@atividade", atividade);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            descricao = reader["descricaoAtividade"].ToString();

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         
         return descricao;
      }
      //=========================================================
      public static string ConverteAluno(int aluno)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAlunos WHERE codAluno = @aluno");

         cmd.Parameters.AddWithValue("@aluno", aluno);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            descricao = reader["nome"].ToString();

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         
         return descricao;
      }
      //=========================================================
      public static string ConvertePeriodo(int periodo)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblPeriodos WHERE codPeriodo = @periodo");

         cmd.Parameters.AddWithValue("@periodo", periodo);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            
            descricao = reader["descricaoPeriodo"].ToString();

         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);
         }
         finally
         {
            Conexao.Desconectar();
         }
         
         return descricao;
      }
      //============ Métodos que preenchem combobox =============
      //=========================================================
      public static DataTable PreencheComboBoxCurso()
      {
         var cmd = new OleDbCommand("SELECT * FROM tblCursos");

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();
         
         DataTable dt = new DataTable();
         
         dt.Load(reader);

         Conexao.Desconectar();
         
         return dt;
      }
      //=========================================================
      public static DataTable PreencheComboBoxTurma()
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAnoTurmas");

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         DataTable dt = new DataTable();

         dt.Load(reader);

         Conexao.Desconectar();

         return dt;
      }
      //=========================================================
      public static DataTable PreencheComboBoxGrupo()
      {
         var cmd = new OleDbCommand("SELECT * FROM tblGrupos");

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         DataTable dt = new DataTable();

         dt.Load(reader);

         Conexao.Desconectar();

         return dt;
      }
      //=========================================================
      public static DataTable PreencheComboBoxPeriodo()
      {
         var cmd = new OleDbCommand("SELECT * FROM tblPeriodos");

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         DataTable dt = new DataTable();

         dt.Load(reader);

         Conexao.Desconectar();

         return dt;
      }
      //=========================================================
      public static DataTable PreencheComboBoxAtividade()
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAtividades");

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         DataTable dt = new DataTable();

         dt.Load(reader);

         Conexao.Desconectar();

         return dt;
      }
   }
}
