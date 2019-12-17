using Classes;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Funcoes
{
   public class Ferramentas
   {
      /// <summary>
      /// Método publico que faz a busca no banco de dados e retorna o código do valor selecionado na combobox.
      /// </summary>
      /// <param name="curso"></param>
      /// <returns></returns>
      public static int BuscaCodigoCurso(string curso)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblCursos WHERE descricaoCurso = @curso");

         cmd.Parameters.AddWithValue("@curso", curso);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
            codigo = (int)reader["codCurso"];
            //Retorna o valor encontrado.

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

      public static int BuscaCodigoTurma(string anoTurma)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAnoTurmas WHERE anoTurma = @turma");

         cmd.Parameters.AddWithValue("@turma", anoTurma);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         int codigo = 0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
            codigo = (int)reader["codTurma"];
            //Retorna o valor encontrado.

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

      public static int BuscaCodigoGrupo(string grupo)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblGrupos WHERE descricaoGrupo = @grupo");

         cmd.Parameters.AddWithValue("@grupo", grupo);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         int codigo=0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
            codigo = (int)reader["codGrupo"];
            //Retorna o valor encontrado.
            
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
      
      public static int BuscaCodigoPeriodo(string periodo)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblPeriodos WHERE descricaoPeriodo = @periodo");

         cmd.Parameters.AddWithValue("@periodo", periodo);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         int codigo=0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
            codigo = (int)reader["codPeriodo"];
            //Retorna o valor encontrado.
            
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
      
      public static int BuscaCodigoAtividade(string atividade)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAtividades WHERE descricaoAtividade = @atividade");

         cmd.Parameters.AddWithValue("@atividade", atividade);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         int codigo=0;

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
            codigo = (int)reader["codAtividade"];
            //Retorna o valor encontrado.
            
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
      public static string ConverteCurso(int curso)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblCursos WHERE codCurso = @curso");

         cmd.Parameters.AddWithValue("@curso", curso);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
            descricao = reader["descricaoCurso"].ToString();
            //Retorna o valor encontrado.

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
      public static string ConverteTurma(int anoTurma)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAnoTurmas WHERE codTurma = @turma");

         cmd.Parameters.AddWithValue("@turma", anoTurma);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
            descricao = reader["anoTurma"].ToString();
            //Retorna o valor encontrado.

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
      public static string ConverteGrupo(int grupo)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblGrupos WHERE codGrupo = @grupo");

         cmd.Parameters.AddWithValue("@grupo", grupo);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         string descricao = "";

         try
         {
            var reader = cmd.ExecuteReader();

            reader.Read();
            //Armazena o valor encontrado pelo cmd dentro da variavel.
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
         //Retorna o valor encontrado.
         return descricao;
      }


      /// <summary>
      /// Método que recupera os dados da tabela no banco de dados e armazena em um DataTable.
      /// </summary>
      /// <returns></returns>
      public static DataTable PreencheComboBoxCurso()
      {
         var cmd = new OleDbCommand("SELECT * FROM tblCursos");

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();
         //Insância um novo DataTable.
         DataTable dt = new DataTable();
         //Preenche o dt com os dados do reader.
         dt.Load(reader);

         Conexao.Desconectar();
         //Retorna os valores encontrados.
         return dt;
      }
      
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
