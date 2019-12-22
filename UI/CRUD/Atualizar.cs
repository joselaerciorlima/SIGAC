using DataBase;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CRUD
{
   class Atualizar
   {
      //=========================================================
      //Construtor para atulizar cadastro do aluno.
      public Atualizar(string codigo, string nome, string matricula, int curso, int anoTurma, string dataAlteracao)
      {
         var cmd = new OleDbCommand("UPDATE tblAlunos SET matricula = @matricula, nome = @nome, codCurso = @codCurso, codTurma = @codTurma, ultimaAlteracao = @alteracao WHERE codAluno LIKE " + codigo);

         cmd.Parameters.AddWithValue("@matricula", matricula);
         cmd.Parameters.AddWithValue("@nome", nome);
         cmd.Parameters.AddWithValue("@codCurso", curso);
         cmd.Parameters.AddWithValue("@codTurma", anoTurma);
         cmd.Parameters.AddWithValue("@alteracao", dataAlteracao);
         
         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro atualizado com sucesso!");
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
      //Construtor para atualizar cadastro da atividade
      public Atualizar(string codigo, string descricao, string cargaHoraria, int grupo, string dataAlteracao)
      {
         var cmd = new OleDbCommand("UPDATE tblAtividades SET codGrupo = @grupo, descricaoAtividade = @descricao, cargaHorariaAtividade = @carga, ultimaAlteracao = @alteracao WHERE codAtividade LIKE " + codigo);

         cmd.Parameters.AddWithValue("@grupo", grupo);
         cmd.Parameters.AddWithValue("@decricao", descricao);
         cmd.Parameters.AddWithValue("@carga", cargaHoraria);
         cmd.Parameters.AddWithValue("@alteracao", dataAlteracao);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro atualizado com sucesso!");
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
      //Construtor para atualizar o cadastro do certificado
      public Atualizar(string codCertificado, string matricula, string codAluno, string descricao, string cargaHoraria, string dataCertificado, int codClassificacao, string dataAlteracao)
      {
         var cmd = new OleDbCommand("UPDATE tblCertificados SET codAluno = @aluno, descricaoCertificado = @descricao, cargaHorariaCertificado = @carga, matricula = @matricula, codAtividade = @classificacao, dataCertificado = @data, ultimaAlteracao = @alteracao WHERE codCertificado LIKE " + codCertificado);

         cmd.Parameters.AddWithValue("@aluno", codAluno);
         cmd.Parameters.AddWithValue("@decricao", descricao);
         cmd.Parameters.AddWithValue("@carga", cargaHoraria);
         cmd.Parameters.AddWithValue("@matricula", matricula);
         cmd.Parameters.AddWithValue("@classificacao", codClassificacao);
         cmd.Parameters.AddWithValue("@data", dataCertificado);
         cmd.Parameters.AddWithValue("@alteracao", dataAlteracao);

         cmd.Connection = Conexao.connection;

         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro atualizado com sucesso!");
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
      //Construtor para atualizar o cadastro do curso
      public Atualizar(string codCurso, string descricao, int periodo, string data)
      {
         var cmd = new OleDbCommand("UPDATE tblCursos SET descricaoCurso = @descricao, codPeriodo = @periodo, ultimaAlteracao = @alteracao WHERE codCurso LIKE " + codCurso);

         cmd.Parameters.AddWithValue("@decricao", descricao);
         cmd.Parameters.AddWithValue("@periodo", periodo);
         cmd.Parameters.AddWithValue("@alteracao", data);

         cmd.Connection = Conexao.connection;
         
         Conexao.Conectar();

         try
         {
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastro atualizado com sucesso!");
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
