using System;
using System.Data.OleDb;

namespace SIGAC_Sistema_Gestao_Atividades_Complementares
{
   class Atualizar
   {
      //Instancia a conexão
      //Conexao conexao = new Conexao();

      //Instancia a classe para escrever comandos
      //SqlCommand cmd = new SqlCommand();
      OleDbCommand cmd = new OleDbCommand();

      public string menssagem = "";
      public Atualizar(string status, int id)
      {
         //Comando Sql -- insert, update, delete

         //Para escrever o comando, utiliza-se o metodo CommandText
         cmd.CommandText = "UPDATE tblAgendamentos SET status=@status WHERE id=@id";

         //Parâmetros
         cmd.Parameters.AddWithValue("@status", status);
         cmd.Parameters.AddWithValue("@id", id);

         //Conectar com o banco

         //Antes de conectar, fazemos uma verificação para ver se não existem erros
         try
         {
            //Recebe o endereço do banco de dado a ser conectado através do método conectar que está dentro da classe conexão
            //cmd.Connection = conexao.conectar();

            //Executar o comando Sql
            cmd.ExecuteNonQuery();

            //Desconectar do banco
            //conexao.desconectar();

            //Mostrar mensagem de erro ou sucesso
            this.menssagem = "Atualizado com sucesso!!";

         }
         //catch (SqlException e)
         catch (OleDbException e)
         {
            this.menssagem = "Erro ao se conectar!";
         }
      }
   }
}
