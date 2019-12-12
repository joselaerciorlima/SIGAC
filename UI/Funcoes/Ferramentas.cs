using Classes;
using System.Data;
using System.Data.OleDb;

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

         var reader = cmd.ExecuteReader();

         reader.Read();
         //Armazena o valor encontrado pelo cmd dentro da variavel.
         var codigo = (int)reader["codCurso"];

         Conexao.Desconectar();
         //Retorna o valor encontrado.
         return codigo;
      }

      /// <summary>
      /// Método publico que faz a busca no banco de dados e retorna o código do valor selecionado na combobox.
      /// </summary>
      /// <param name="curso"></param>
      /// <returns></returns>
      public static int BuscaCodigoTurma(string anoTurma)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblAnoTurmas WHERE anoTurma = @turma");

         cmd.Parameters.AddWithValue("@turma", anoTurma);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         reader.Read();
         //Armazena o valor encontrado pelo cmd dentro da variavel.
         var codigo = (int)reader["codTurma"];

         Conexao.Desconectar();
         //Retorna o valor encontrado.
         return codigo;
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
      /// <summary>
      /// Método que recupera os dados da tabela no banco de dados e armazena em um DataTable.
      /// </summary>
      /// <returns></returns>
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
   }
}
