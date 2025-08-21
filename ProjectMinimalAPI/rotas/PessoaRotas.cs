using ProjectMinimalAPI.Models;

namespace ProjectMinimalAPI.rotas
{
    public  static class PessoaRotas
    {
        public static List<Pessoa> Pessoas = new()
        {
            new (Guid.NewGuid(), "Neymar"),
            new (Guid.NewGuid(), "Messi"),
            new (Guid.NewGuid(), "Cristiano Ronaldo")
        }

        public static void MapPessoaRotas(this WebApplication app)
        {
            app.MapGet(pattern: "/hello-world", handler: () => new {Nome="Criss" });
        }
    }
}
