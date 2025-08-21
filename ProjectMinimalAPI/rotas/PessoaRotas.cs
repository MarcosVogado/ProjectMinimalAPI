using ProjectMinimalAPI.Models;

namespace ProjectMinimalAPI.rotas
{
    public  static class PessoaRotas
    {
        public static List<Pessoa> Pessoas = new()
        {
            // Inicializando a lista de pessoas com alguns dados
            //.NewGuid() gera um novo GUID aleatório
            new (Guid.NewGuid(), "Neymar"),
            new (Guid.NewGuid(), "Messi"),
            new (Guid.NewGuid(), "Cristiano Ronaldo")
        };

        public static void MapPessoaRotas(this WebApplication app)
        {
            // Define a rota para obter todas as pessoas
            // O método MapGet define uma rota HTTP GET
            app.MapGet(pattern: "/pessoas", handler:() => Pessoas );
        }
    }
}
