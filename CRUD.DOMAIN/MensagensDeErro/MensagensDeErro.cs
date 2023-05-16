

namespace CRUD.DOMAIN.MensagensDeErro
{
    public static class MensagensDeErro
    {
        public const string FALHA_JOGADOR_NAO_ENCONTRADO = "O jogador não foi encontrado!\n";
        public const string FALHA_DATA_DE_NASCIMENTO_MAIOR_QUE_ATUAL = "A data de nascimento não pode ser maior que a data atual!\n";

        public const string FALHA_NOME_NAO_PODE_SER_NULO = "O campo nome não pode ser nulo";
        public const string FALHA_NOME_TAMANHO = "O campo Nome deve conter no mínimo 3 caracteres, e no máximo 50!\n";

        public const string FALHA_SOBRENOME_NAO_PODE_SER_NULO = "O campo sobrenome não pode ser nulo";
        public const string FALHA_SOBRENOME_TAMANHO = "O campo Sobrenome deve conter no mínimo 3 caracteres, e no máximo 50!\n";

        public const string FALHA_EMAIL_NAO_PODE_SER_NULO = "O campo Email não pode ser nulo";
        public const string FALHA_EMAIL_INVALIDO = "O campo Email inválido. Formato esperado: (exemplo@exemplo.com).\n";
        public const string FALHA_EMAIL_EXISTENTE = "Este email já está sendo utilizado";
        public const string FALHA_EMAIL_TAMANHO = "O campo Email deve conter no mínimo 3 caracteres, e no máximo 70!\n";

        public const string FALHA_APELIDO_NAO_PODE_SER_NULO = "O campo Apelido não pode ser nulo!\n";
        public const string FALHA_APELIDO_TAMANHO = "O campo Apelido deve conter no mínimo 3 caracteres, e no máximo 50!\n";
        public const string FALHA_APELIDO_EXISTENTE = "O Apelido inserido já está em uso!\n";

        public const string FALHA_LINHA_NAO_ENCONTRADA = "A linha não foi encontrada.\n";

        
    }
}
