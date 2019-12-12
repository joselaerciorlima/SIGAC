using Classes;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
      public Cadastrar(string descricao, int cargaHoraria, int grupo)
      {

      }
      /// <summary>
      /// Construtor para cadastrar certificado.
      /// </summary>
      /// <param name="matricula"></param>
      /// <param name="atividade"></param>
      /// <param name="descricao"></param>
      /// <param name="dataCertificado"></param>
      /// <param name="cargaHoraria"></param>
      public Cadastrar(int matricula, int atividade, string descricao, string dataCertificado, int cargaHoraria)
      {

      }

   }
}
