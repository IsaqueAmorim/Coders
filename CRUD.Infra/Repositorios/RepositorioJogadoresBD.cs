using CRUD.Modelos;
using System.Data.SqlClient;
using System.Configuration;
using CRUD.DOMAIN.MensagensDeErro;
using CRUD.DOMAIN.Constantes;

namespace CRUD.Repositorios
{
    public class RepositorioJogadoresBD : IRepositorioJogadores
    {
        private SqlConnection _conexao = new SqlConnection(
            ConfigurationManager
            .ConnectionStrings[ConstantesConfig.BANCO_PADRAO]
            .ConnectionString);

        public void AtualizarJogador(JogadorModelo jogador)
        {
            var atualizarSQL = "UPDATE tb_jogadores SET " +
                "Nome = @Nome," +
                "Sobrenome = @Sobrenome," +
                "Apelido = @Apelido," +
                "Email = @Email," +
                "Elo = @Elo," +
                "Data_de_Nascimento = @DataNascimento," +
                "Data_de_Criacao = @DataCriacao" +
                " WHERE Id = @id";
            try 
            {
                _conexao.Open();

                var command = new SqlCommand(atualizarSQL, _conexao);

                command.Parameters.AddWithValue("@Nome", jogador.Nome);
                command.Parameters.AddWithValue("@Sobrenome", jogador.Sobrenome);
                command.Parameters.AddWithValue("@Apelido", jogador.Apelido);
                command.Parameters.AddWithValue("@Email", jogador.Email);
                command.Parameters.AddWithValue("@Elo", jogador.Elo.ToString());
                command.Parameters.AddWithValue("@DataNascimento", jogador.DataNascimento);
                command.Parameters.AddWithValue("@DataCriacao", jogador.DataCriacao);
                command.Parameters.AddWithValue("@id", jogador.Id);
                command.ExecuteNonQuery();

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _conexao.Close();
            }
         
        }

        public long CriarJogador(JogadorModelo jogador)
        {
            string insert =
               $"INSERT INTO TB_Jogadores (Nome,Sobrenome,Apelido,Email,Elo,Data_de_Nascimento,Data_de_Criacao) " +
               $"Values(@Nome,@Sobrenome,@Apelido,@Email,@Elo,@Data_de_Nascimento,@Data_de_Criacao)";
            try 
            {
                _conexao.Open();

                var command = new SqlCommand(insert, _conexao);

                command.Parameters.AddWithValue("@Nome", jogador.Nome);
                command.Parameters.AddWithValue("@Sobrenome", jogador.Sobrenome);
                command.Parameters.AddWithValue("@Apelido", jogador.Apelido);
                command.Parameters.AddWithValue("@Email", jogador.Email);
                command.Parameters.AddWithValue("@Elo", jogador.Elo.ToString());
                command.Parameters.AddWithValue("@Data_de_Nascimento", jogador.DataNascimento);
                command.Parameters.AddWithValue("@Data_de_Criacao", jogador.DataCriacao);

                command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
            _conexao.Close();
            }
            return jogador.Id;
        }
    
        public void DeletarJogador(long id)
        {
           
            try
            {
                _conexao.Open();
                string select = "DELETE FROM tb_jogadores WHERE Id = @id";
                var command = new SqlCommand(select, _conexao);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw new Exception(MensagensDeErro.FALHA_JOGADOR_NAO_ENCONTRADO);
            }
            finally
            {
                _conexao.Close();
            }
        }

       

        public JogadorModelo ObterJogadorPorId(long id)
        {
            SqlDataReader reader;
            var jogador = new JogadorModelo();
            var JogadoresLista = new List<JogadorModelo>();
            try
            {
                _conexao.Open();
                string select = "SELECT * FROM tb_jogadores WHERE Id = @id";
                var command = new SqlCommand(select, _conexao);
                command.Parameters.AddWithValue("@id", id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    jogador = MapearJogadorModelo(reader);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(MensagensDeErro.FALHA_JOGADOR_NAO_ENCONTRADO);
            }
            finally
            {
                _conexao.Close();
            }
            return jogador;

        }

        public List<JogadorModelo> ObterTodosJogadores()
        {
            SqlDataReader reader;
            var JogadoresLista = new List<JogadorModelo>();
            try
            {
                _conexao.Open();
                var command = new SqlCommand("SELECT * FROM tb_jogadores", _conexao);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    JogadoresLista.Add(MapearJogadorModelo(reader));
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _conexao.Close();
            }

            return JogadoresLista;
        }

        private JogadorModelo MapearJogadorModelo(SqlDataReader data)
        {
            SqlDataReader reader = data;
            var Jogador = new JogadorModelo()
            {
                Id = (long)reader["Id"],
                Nome = (string)reader["Nome"],
                Sobrenome = (string)reader["Sobrenome"],
                Email = (string)reader["Email"],
                Elo = Servicos.Validacao.StringParaElo((string)reader["Elo"]),
                Apelido = (string)reader["Apelido"],
                DataNascimento = (DateTime)reader["Data_de_Nascimento"],
                DataCriacao = (DateTime)reader["Data_de_Criacao"]

            };
            return Jogador;
        }
    }
}