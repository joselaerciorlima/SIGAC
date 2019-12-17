using Classes;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Funcoes
{
   public class Cadastrar
   {
      /// <summary>
      /// Construtor para cadastrar aluno.
      /// </summary>
      /// <param name="nome"></param>
      /// <param name="matricula"></param>
      /// <param name="curso"></param>
      /// <param name="anoTurma"></param>
      /// <param name="dataCadastro"></param>
      public Cadastrar(string nome, string matricula, int curso, int anoTurma, string dataCadastro)
      {
         var cmd = new OleDbCommand("INSERT INTO tblAlunos (matricula,nome,codCurso,codTurma,dataCadastro) VALUES (@matricula,@nome,@codCurso,@anoTurma,@dataCadastro)");

         cmd.Parameters.AddWithValue("@matricula", matricula);
         cmd.Parameters.AddWithValue("@nome", nome);
         cmd.Parameters.AddWithValue("@codCurso", curso);
         cmd.Parameters.AddWithValue("@codTurma", anoTurma);
         cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
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
      /// <summary>
      /// Construtor para cadastrar atividade complementar.
      /// </summary>
      /// <param name="descricao"></param>
      /// <param name="cargaHoraria"></param>
      /// <param name="grupo"></param>
      public Cadastrar(string descricao, string cargaHoraria, int grupo, string dataCadastro)
      {
         var cmd = new OleDbCommand("INSERT INTO tblAtividades (codGrupo,descricaoAtividade,cargaHorariaAtividade,dataCadastro) VALUES (@codGrupo,@descricao,@cargaHoraria,@dataCadastro)");

         cmd.Parameters.AddWithValue("@codGrupo", grupo);
         cmd.Parameters.AddWithValue("@descricao", descricao);
         cmd.Parameters.AddWithValue("@cargaHoraria", cargaHoraria);
         cmd.Parameters.AddWithValue("@dataCadastro", dataCadastro);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
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
      /// <summary>
      /// Construtor para cadastrar certificado.
      /// </summary>
      /// <param name="atividade"></param>
      /// <param name="matricula"></param>
      /// <param name="descricao"></param>
      /// <param name="dataCertificado"></param>
      /// <param name="cargaHoraria"></param>
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
         //Chama o método de conexão que está dentro da classe 'Conexao'.
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
      /// <summary>
      /// Construtor para cadastrar curso.
      /// </summary>
      /// <param name="descricao"></param>
      /// <param name="periodo"></param>
      public Cadastrar(string descricao, int periodo)
      {
         var cmd = new OleDbCommand("INSERT INTO tblCursos (descricaoCurso,codPeriodo) VALUES (@descricao,@periodo)");

         cmd.Parameters.AddWithValue("@descricao", descricao);
         cmd.Parameters.AddWithValue("@periodo", periodo);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
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
