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

            // Define a rota para obter uma pessoa pelo nome
            // O parâmetro {nome} na rota indica que é um valor dinâmico que será passado na URL
            // O handler recebe o nome como parâmetro e retorna a pessoa correspondente
            app.MapGet("/pessoas/{nome}", handler:(string nome) => Pessoas.Find(x => x.Nome == nome));

            // Define a rota para adicionar uma nova pessoa
            app.MapPost("pessoas", (Pessoa pessoa) =>
            {
                if(pessoa.Nome.Length < 1)
                {
                    return Results.BadRequest();
                }

                Pessoas.Add(pessoa);
                return Results.Ok(pessoa);
            });
        }
    }
}
