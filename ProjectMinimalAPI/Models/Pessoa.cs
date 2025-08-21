namespace ProjectMinimalAPI.Models
{
    public class Pessoa
    {
        //Propriedades da classe Pessoa
        //Adicionando getters e setters para as propriedades
        // Id será do tipo Guid(Token aleatório) e Nome será do tipo String
        public Guid Id { get; set; }
        public String Nome { get; set; }

        //Fazendo um método construtor para inicializar os valores
        public Pessoa(Guid id, String nome)
            {
                Id = id;
                Nome = nome;
            }
    }
}
