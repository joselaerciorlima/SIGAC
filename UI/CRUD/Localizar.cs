using DataBase;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CRUD
{
   public class Localizar
   {
      //=========================================================
      //Construtor para localizar cadastro do aluno
      public static OleDbDataReader PesquisarAluno(string filtro, RadioButton matricula, RadioButton nome)
      {
         string comando;
         if (matricula.Checked == true)
         {
            comando = "SELECT * FROM tblAlunos WHERE matricula LIKE '" + filtro + "%'";
         }
         else if (nome.Checked == true)
         {
            comando = "SELECT * FROM tblAlunos WHERE nome LIKE '" + filtro + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblAlunos";
         }

         var cmd = new OleDbCommand(comando);

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         return reader;
      }
      //=========================================================
      //Construtor para localizar cadastro da atividade complementar
      public static OleDbDataReader PesquisarAtividade(string filtro)
      {
         string comando;
         if (filtro != "")
         {
            comando = "SELECT * FROM tblAtividades WHERE descricaoAtividade LIKE '" + filtro + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblAtividades";
         }

         var cmd = new OleDbCommand(comando);

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         return reader;
      }
      //=========================================================
      //Construtor para localizar cadastro do certificado
      public static OleDbDataReader PesquisarCertificado(string filtro)
      {
         string comando;
         if (filtro != "")
         {
            comando = "SELECT * FROM tblCertificados WHERE matricula LIKE '" + filtro + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblCertificados";
         }

         var cmd = new OleDbCommand(comando);

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         return reader;
      }
      //=========================================================
      //Construtor para localizar cadastro do curso
      public static OleDbDataReader PesquisarCurso(string filtro)
      {
         string comando;
         if (filtro != "")
         {
            comando = "SELECT * FROM tblCursos WHERE descricaoCurso LIKE '" + filtro + "%'";
         }
         else
         {
            comando = "SELECT * FROM tblCursos";
         }

         var cmd = new OleDbCommand(comando);

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         var reader = cmd.ExecuteReader();

         return reader;
      }
   }
}
