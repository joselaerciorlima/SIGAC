using DataBase;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CRUD
{
   public class Cadastrar
   {
      //=========================================================
      //Construtor para cadastrar aluno
      public Cadastrar(string nome, string matricula, int curso, int anoTurma, string dataCadastro)
      {
         var cmd = new OleDbCommand("INSERT INTO tblAlunos (matricula,nome,codCurso,codTurma,dataCadastro) VALUES (@matricula,@nome,@codCurso,@anoTurma,@dataCadastro)");

         cmd.Parameters.AddWithValue("@matricula", matricula);
         cmd.Parameters.AddWithValue("@nome", nome);
         cmd.Parameters.AddWithValue("@codCurso", curso);
         cmd.Parameters.AddWithValue("@codTurma", anoTurma);
         cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro realizado com sucesso!");
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
      //=========================================================
      //Construtor para cadastro de atividade complementar
      public Cadastrar(string descricao, string cargaHoraria, int grupo, string dataCadastro)
      {
         var cmd = new OleDbCommand("INSERT INTO tblAtividades (codGrupo,descricaoAtividade,cargaHorariaAtividade,dataCadastro) VALUES (@codGrupo,@descricao,@cargaHoraria,@dataCadastro)");

         cmd.Parameters.AddWithValue("@codGrupo", grupo);
         cmd.Parameters.AddWithValue("@descricao", descricao);
         cmd.Parameters.AddWithValue("@cargaHoraria", cargaHoraria);
         cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro realizado com sucesso!");
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
      //=========================================================
      //Construtor para cadastro de certificado
      public Cadastrar(string matricula, string codAluno, string dataCertificado, string descricao, int atividade, string cargaHoraria, string dataCadastro)
      {
         var cmd = new OleDbCommand("INSERT INTO tblCertificados (matricula,codAluno,dataCertificado,descricaoCertificado,codAtividade,cargaHorariaCertificado,dataCadastro) VALUES (@matricula,@codAluno,@data,@descricao,@codAtividade,@carga,@dataCadastro)");

         cmd.Parameters.AddWithValue("@matricula", matricula);
         cmd.Parameters.AddWithValue("@codAluno", codAluno);
         cmd.Parameters.AddWithValue("@data", dataCertificado);
         cmd.Parameters.AddWithValue("@descricao", descricao);
         cmd.Parameters.AddWithValue("@codAtividade", atividade);
         cmd.Parameters.AddWithValue("@carga", cargaHoraria);
         cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro realizado com sucesso!");
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
      //=========================================================
      //Construtor para cadastro de curso     
      public Cadastrar(string descricao,int periodo,string data)
      {
         var cmd = new OleDbCommand("INSERT INTO tblCursos (descricaoCurso,codPeriodo,dataCadastro) VALUES (@descricao,@periodo,@dataCadastro)");

         cmd.Parameters.AddWithValue("@descricao", descricao);
         cmd.Parameters.AddWithValue("@periodo", periodo);
         cmd.Parameters.AddWithValue("@dataCadastro", data);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro realizado com sucesso!");
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
