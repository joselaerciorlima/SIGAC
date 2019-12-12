using System.Data.OleDb;
using System.Configuration;

namespace Classes
{
   public class Conexao
   {
      /// <summary>
      /// Método público de verifica se o caminho do banco de dados existe, caso não ele cria as pastas.
      /// </summary>
      public static void VerificaCaminho()
      {
         if (!System.IO.Directory.Exists(@"C:\SIGAC\Banco de Dados"))
         {
            System.IO.Directory.CreateDirectory(@"C:\SIGAC\Banco de Dados\");
         }
      }

      /// <summary>
      /// Método público que define a string de conexão do banco de dados recuperando o caminho do banco direto do arquivo de configuração.
      /// </summary>
      public static string conectionstring()
      {
         VerificaCaminho();

         var stringConexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["caminho_banco"] + "DataBaseSIGAC.mdb";

         return stringConexao;
      }

      //Instancia uma nova conexão passando a string de conexão.
      public static OleDbConnection connection = new OleDbConnection(conectionstring());

      /// <summary>
      /// Método público que abre conexão com o banco de dados.
      /// </summary>
      public static void Conectar()
      {
         if (connection.State == System.Data.ConnectionState.Closed)
         {
            connection.Open();
         }
      }

      /// <summary>
      /// Método público que fecha a conexão o banco de dados.
      /// </summary>
      public static void Desconectar()
      {
         if (connection.State == System.Data.ConnectionState.Open)
         {
            connection.Close();
         }
      }
   }
}
