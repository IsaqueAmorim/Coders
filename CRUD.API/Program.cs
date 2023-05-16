

using CRUD.Infra.Repositorios;
using CRUD.Repositorios;
using CRUD.Servicos;
using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

//Desabilitando CORS no localhost
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:7139",
                                              "http://localhost:8080");
                      });
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IRepositorioJogadores, Link2DBRepositorio>();
builder.Services.AddScoped<Validacao>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles(new StaticFileOptions
{
    ServeUnknownFileTypes = true,
    DefaultContentType = "text/plain;charset=utf-8",
    ContentTypeProvider = new FileExtensionContentTypeProvider(new Dictionary<string, string>
 {
 {".properties", "text/plain;charset=utf-8" }
 })
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
