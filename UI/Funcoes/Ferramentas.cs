using Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
   public class Ferramentas
   {
      public static int BuscaCodigo(string curso)
      {
         var cmd = new OleDbCommand("SELECT * FROM tblCursos WHERE descricaoCurso = @curso");

         cmd.Parameters.AddWithValue("@curso", curso);
         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         reader.Read();

         var codigo = (int)reader["codCurso"];

         Conexao.Desconectar();

         return codigo;
      }
   }
}
