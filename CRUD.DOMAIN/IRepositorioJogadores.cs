using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Modelos;

namespace CRUD.Repositorios
{
    public interface IRepositorioJogadores
    {
        public long CriarJogador(JogadorModelo jogador);
        public JogadorModelo ObterJogadorPorId(long id);
        public List<JogadorModelo> ObterTodosJogadores();
        public void DeletarJogador(long id);
        public void AtualizarJogador(JogadorModelo jogador);

    

    }
}
