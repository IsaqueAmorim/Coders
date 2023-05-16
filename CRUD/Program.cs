using System.Configuration;
using CRUD.Infra.Data.Migrations;
using CRUD.Infra.Repositorios;
using CRUD.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CRUD
{
    public static class Program
    {
        
        [STAThread]
        static void Main()
        {

            var builder = CriarHostBuilder();
            var provedorServicos = builder.Build().Services;
            var repositorio = provedorServicos.GetService<IRepositorioJogadores>();
            Application.Run(new FormularioListagem(repositorio));

        }

     
        

        static IHostBuilder CriarHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((_context, services) =>
                {
                    services.AddScoped<IRepositorioJogadores, RepositorioJogadoresBD>();
                    services.AddScoped<IRepositorioJogadores, Link2DBRepositorio>();

                });
        }


    }
    
}