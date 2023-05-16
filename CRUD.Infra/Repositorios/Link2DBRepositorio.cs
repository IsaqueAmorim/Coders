using CRUD.DOMAIN.Constantes;
using CRUD.DOMAIN.MensagensDeErro;
using CRUD.Modelos;
using CRUD.Repositorios;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;
using System.Configuration;
namespace CRUD.Infra.Repositorios
{
    public class Link2DBRepositorio : IRepositorioJogadores
    {
        static string connectionString = ConfigurationManager
               .ConnectionStrings[ConstantesConfig.BANCO_PADRAO]
               .ConnectionString;

        DataConnection _conexao = SqlServerTools.CreateDataConnection(connectionString);
        
        public void AtualizarJogador(JogadorModelo jogador)
        {
            _conexao.Update<JogadorModelo>(jogador);
        }

        public long CriarJogador(JogadorModelo jogador)
        {
            jogador.DataCriacao = DateTime.Now;
            var id =_conexao.InsertWithInt32Identity<JogadorModelo>(jogador);

            return id;
        }

        public void DeletarJogador(long id)
        {
            var jogador = ObterJogadorPorId(id);
            _conexao.Delete<JogadorModelo>(jogador);
             
        }

        public JogadorModelo ObterJogadorPorId(long id)
        {

            return _conexao.GetTable<JogadorModelo>().FirstOrDefault(jogador => jogador.Id == id) ?? throw new Exception(MensagensDeErro.FALHA_JOGADOR_NAO_ENCONTRADO); ;
        }

        public List<JogadorModelo> ObterTodosJogadores()
        {
            var jogadores = _conexao.GetTable<JogadorModelo>().ToList();

            return jogadores;
        }

    }
}
