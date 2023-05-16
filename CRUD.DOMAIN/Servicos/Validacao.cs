using System.Text;
using System.Text.RegularExpressions;
using CRUD.DOMAIN.MensagensDeErro;
using CRUD.Modelos;
using CRUD.Repositorios;

namespace CRUD.Servicos
{
    public class Validacao
    {
        private static List<JogadorModelo> Jogadores;

        private readonly IRepositorioJogadores _repositorio;

        public Validacao(IRepositorioJogadores repositorioJogadores)
        {
            _repositorio = repositorioJogadores;
            Jogadores = repositorioJogadores.ObterTodosJogadores();
            
        }

        public void ValidaCriacaoJogadorModelo(JogadorModelo jogador)
        {
            string stringBuilder ="";
            if (ValidaString(jogador.Nome) == false)
            {
                stringBuilder +=MensagensDeErro.FALHA_NOME_TAMANHO;

            }
            if (ValidaDataNascimento(jogador.DataCriacao, jogador.DataNascimento) == false)
            {

                stringBuilder += MensagensDeErro.FALHA_DATA_DE_NASCIMENTO_MAIOR_QUE_ATUAL;
            }
            if (ValidaEmail(jogador.Email) == false)
            {
                stringBuilder += MensagensDeErro.FALHA_EMAIL_INVALIDO;     
            }
            if (ValidaString(jogador.Apelido) == false)
            {
                stringBuilder +=MensagensDeErro.FALHA_APELIDO_TAMANHO;
            }
            
            if (ValidaApelido(jogador.Apelido) == false)
            {
                stringBuilder += MensagensDeErro.FALHA_APELIDO_EXISTENTE;
            }

            if(stringBuilder.Length > 0)
            {
                throw new Exception(stringBuilder);
            }
            
        }

        private static bool ValidaString(string data)
        {
            if (data.Length == 0) return false;
            if (data.Contains(" ")) return false;

            return true;

        }

        private static bool ValidaDataNascimento(DateTime criacao, DateTime nascimento)
        {
            if (nascimento >= DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public static bool ValidaEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (rg.IsMatch(email))
            {
                if (Jogadores.Exists(X => X.Email == email))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public static Elo StringParaElo(string elo)
        {
            Elo result;

            switch (elo)
            {
                case "Ferro":
                    result = Elo.Ferro;
                    break;
                case "Bronze":
                    result = Elo.Bronze;
                    break;
                case "Prata":
                    result = Elo.Prata;
                    break;
                case "Ouro":
                    result = Elo.Ouro;
                    break;
                case "Platina":
                    result = Elo.Platina;
                    break;
                case "Diamante":
                    result = Elo.Diamante;
                    break;
                case "Mestre":
                    result = Elo.Mestre;
                    break;
                case "GM":
                    result = Elo.GM;
                    break;
                case "Desafiante":
                    result = Elo.Desafiante;
                    break;
                default:
                    result = Elo.Ferro;
                    break;
            }
            return result;
        }

        private static bool ValidaId(long id)
        {
            
            if (Jogadores.Exists(x => x.Id == id))
            {
                return false;
            }

            return true;
        }

        private static bool ValidaApelido(string apelido)
        {
            if (apelido != null && apelido.Length >= 1)
            {
                if (Jogadores.Exists(x => x.Apelido == apelido)) return false;
            }
            return true;
        }

        public static void ValidaQuantidadeDeLinhasSelecionadas(int numeroDeLinhas)
        {
            if (numeroDeLinhas == 0)
            {
                throw new Exception("ERR: Você deve selecionar uma linha para editar!");
            }
            else if (numeroDeLinhas > 1)
            {
                throw new Exception("ERR: Você deve selecionar apenas um linha para editar");
            }
        }

        public static string ValidaUnicidadeEmail(JogadorModelo jogador, string email)
        {
            if (jogador.Email != email)
            {
                if (ValidaEmail(email))
                {
                    return email;
                }
                else
                {
                    throw new Exception(MensagensDeErro.FALHA_EMAIL_EXISTENTE);
                }
            }
            else
            {
                return jogador.Email;
            }
        }

        public static string ValidaUnicidadeApelido(JogadorModelo jogador, string apelido)
        {
            if (jogador.Apelido != apelido)
            {
                if (ValidaApelido(apelido))
                {
                    return apelido;
                }
                else
                {
                    throw new Exception(MensagensDeErro.FALHA_APELIDO_EXISTENTE);
                   
                }
            }
            else
            {
                return jogador.Apelido;
            }
        }

      
    }
}
