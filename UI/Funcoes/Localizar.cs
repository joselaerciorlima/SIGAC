using Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcoes
{
   public class Localizar
   {
      public static DataTable PesquisarAluno(string filtro, bool filtrarTudo)
      {
         string comando = "";
         OleDbCommand cmd;

         if (filtrarTudo == true)
         {
            comando = "SELECT * FROM tblAlunos";
            cmd = new OleDbCommand(comando);
         }
         else
         {
            comando = "SELECT * FROM tblAlunos WHERE matricula LIKE @matricula OR nome LIKE @nome";
            cmd = new OleDbCommand(comando);

            cmd.Parameters.AddWithValue("@matricula", filtro);
            cmd.Parameters.AddWithValue("@nome", filtro);
         }

         //cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         OleDbDataAdapter adapter = new OleDbDataAdapter(comando,Conexao.connection);
         
         //Insância um novo DataTable.
         DataTable dt = new DataTable();

         try
         {
            adapter.Fill(dt);
            
            //var reader = cmd.ExecuteReader();
            
            //Preenche o dt com os dados do reader.
            //dt.Load(reader);
            
            
         }
         catch (Exception erro)
         {
            MessageBox.Show(erro.Message);

         }
         finally
         {
            Conexao.Desconectar();

         }
         //Retorna os valores encontrados.
         return dt;


      }


   }
}
