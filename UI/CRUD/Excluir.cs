using DataBase;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CRUD
{
   class Excluir
   {
      //========================================================
      //Método construtor para exclusão do registro. Serve para todos os cadastros.
      public Excluir(string codigo, TextBox textbox)
      {
         string nomeText = textbox.Name;
         string subString = nomeText.Substring(6);

         var cmd = new OleDbCommand("DELETE FROM tbl" + subString + "s WHERE cod" + subString + "= @codigo");

         cmd.Parameters.AddWithValue("@codigo", codigo);

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro excluido com sucesso!");
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
