using CRUD.DOMAIN.MensagensDeErro;
using CRUD.Modelos;

namespace CRUD.Repositorios
{
    public class RepositorioJogadoresEmMemoria:IRepositorioJogadores
    {
        private List<JogadorModelo> listaJogadores = ListaSingleton.ObterInstancia();
        public void AtualizarJogador(JogadorModelo jogadorAtualizado)
        {
            var jogador = listaJogadores.FirstOrDefault(x => x.Id == jogadorAtualizado.Id);
            listaJogadores[listaJogadores.IndexOf(jogador)] = jogadorAtualizado;
        }

        public long CriarJogador(JogadorModelo jogador)
        {
            listaJogadores.Add(jogador);
            return jogador.Id;
        }

        public void DeletarJogador(long id)
        {
           var jogador = listaJogadores.FirstOrDefault(x => x.Id == id);
            listaJogadores.Remove(jogador);
        }

        public JogadorModelo ObterJogadorPorId(long id)
        {
            var jogador = listaJogadores.Find(x => x.Id == id)
                ?? throw new Exception(MensagensDeErro.FALHA_JOGADOR_NAO_ENCONTRADO);

            return jogador;
        }

        public List<JogadorModelo> ObterTodosJogadores()
        {
            return listaJogadores;
        }
    }
}
