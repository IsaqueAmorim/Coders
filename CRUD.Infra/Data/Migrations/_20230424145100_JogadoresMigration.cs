using FluentMigrator;

namespace CRUD.Infra.Data.Migrations
{
    [Migration(20230424145100)]
    public class _20230424145100_JogadoresMigration : Migration
    {
        public override void Up()
        {
            Create.Table("tb_jogadores")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity().Unique()
                .WithColumn("Nome").AsString().NotNullable()
                .WithColumn("Sobrenome").AsString().NotNullable()
                .WithColumn("Email").AsString().NotNullable()
                .WithColumn("Apelido").AsString().Unique().NotNullable()
                .WithColumn("Elo").AsString().NotNullable()
                .WithColumn("Data_de_Nascimento").AsDateTime().NotNullable()
                .WithColumn("Data_de_Criacao").AsDateTime().NotNullable();


        }

        public override void Down()
        {
            Delete.Table("tb_jogadores");
        }
    }
}