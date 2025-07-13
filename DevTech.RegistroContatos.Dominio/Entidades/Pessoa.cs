namespace DevTech.RegistroContatos.Dominio.Entidades;

public class Pessoa
{
    public Guid Id { get; init; }
    public string Nome { get; set; } = string.Empty;
    public DateTime DtNascimento{ get; set; }
    public string Cpf { get; set; } = string.Empty;

    public List<Contato> Contatos = [];
}
