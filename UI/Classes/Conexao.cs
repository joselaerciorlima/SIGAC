using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace Classes
{
   public class Conexao
   {
      public static string conectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["caminho_banco"] + "DataBaseSIGAC.mdb";

      public static OleDbConnection connection = new OleDbConnection(conectionstring);

      public static void Conectar()
      {
         if (connection.State == System.Data.ConnectionState.Closed)
         {
            connection.Open();
         }
      }
      public static void Desconectar()
      {
         if (connection.State == System.Data.ConnectionState.Open)
         {
            connection.Close();
         }
      }


   }
}
