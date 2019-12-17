using Classes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcoes
{
   class Atualizar
   {
      public Atualizar(string codigo, string nome, string matricula, int curso, int anoTurma, string dataAlteracao)
      {
         var cmd = new OleDbCommand("UPDATE tblAlunos SET matricula = @matricula, nome = @nome, codCurso = @codCurso, codTurma = @codTurma, ultimaAlteracao = @alteracao WHERE codAluno LIKE " + codigo);

         cmd.Parameters.AddWithValue("@matricula", matricula);
         cmd.Parameters.AddWithValue("@nome", nome);
         cmd.Parameters.AddWithValue("@codCurso", curso);
         cmd.Parameters.AddWithValue("@codTurma", anoTurma);
         cmd.Parameters.AddWithValue("@alteracao", dataAlteracao);
         //cmd.Parameters.AddWithValue("@codigo", codigo);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
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
      public Atualizar(string codigo, string descricao, string cargaHoraia, int grupo, string dataAlteracao)
      {
         var cmd = new OleDbCommand("UPDATE tblAtividades SET codGrupo = @grupo, descricaoAtividade = @descricao, cargaHorariaAtividade = @carga, ultimaAlteracao = @alteracao WHERE codAtividade LIKE " + codigo);

         cmd.Parameters.AddWithValue("@grupo", grupo);
         cmd.Parameters.AddWithValue("@decricao", descricao);
         cmd.Parameters.AddWithValue("@carga", cargaHoraia);
         cmd.Parameters.AddWithValue("@alteracao", dataAlteracao);

         cmd.Connection = Conexao.connection;
         //Chama o método de conexão que está dentro da classe 'Conexao'.
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
