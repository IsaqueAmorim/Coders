using CRUD.DOMAIN.MensagensDeErro;
using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Modelos
{
    [Table("tb_jogadores")]
    public class JogadorModelo
    {
        [PrimaryKey, Identity]
        public long Id { get; set; }

        [NotNull(MensagensDeErro.FALHA_NOME_NAO_PODE_SER_NULO)]
        [MaxLength(50,ErrorMessage = MensagensDeErro.FALHA_NOME_TAMANHO)]
        [MinLength(2, ErrorMessage = MensagensDeErro.FALHA_NOME_TAMANHO)]
        [Column("Nome")]
        public string Nome { get; set; }


        [NotNull(MensagensDeErro.FALHA_SOBRENOME_NAO_PODE_SER_NULO)]
        [MaxLength(50, ErrorMessage = MensagensDeErro.FALHA_SOBRENOME_TAMANHO)]
        [MinLength(2, ErrorMessage = MensagensDeErro.FALHA_SOBRENOME_TAMANHO)]
        [Column("Sobrenome")]
        public string Sobrenome { get; set; }


        [NotNull(MensagensDeErro.FALHA_APELIDO_NAO_PODE_SER_NULO)]
        [MaxLength(50, ErrorMessage = MensagensDeErro.FALHA_APELIDO_TAMANHO)]
        [MinLength(2, ErrorMessage = MensagensDeErro.FALHA_APELIDO_TAMANHO)]
        [Column("Apelido")]
        public string Apelido { get; set; }


        [NotNull(MensagensDeErro.FALHA_EMAIL_NAO_PODE_SER_NULO)]
        [MaxLength(70, ErrorMessage = MensagensDeErro.FALHA_EMAIL_TAMANHO)]
        [MinLength(2, ErrorMessage = MensagensDeErro.FALHA_EMAIL_TAMANHO)]
        [Column("Email")]
        public string Email { get; set; }


        [Column("Elo")]
        public Elo Elo { get; set; }


        [Column("Data_de_Nascimento")]
        public DateTime DataNascimento { get; set; }


        [Column("Data_de_Criacao")]
        public DateTime DataCriacao { get; set; }


        public JogadorModelo(string nome, string sobrenome, string apelido, string email, Elo elo, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Apelido = apelido;
            Email = email;
            Elo = elo;
            DataNascimento = dataNascimento;
        }
        public JogadorModelo()
        {

        }
        public JogadorModelo(JogadorModelo jogador)
        {
            Nome = jogador.Nome;
            Sobrenome = jogador.Sobrenome;
            Email = jogador.Email;
            Apelido = jogador.Apelido;
            Elo = jogador.Elo;
            DataNascimento = jogador.DataNascimento;
            DataCriacao = DateTime.Now;

        }



    }
}
