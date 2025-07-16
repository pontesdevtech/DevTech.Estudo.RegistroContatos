using DevTech.RegistroContatos.Dominio.Enums;

namespace DevTech.RegistroContatos.Dominio.Entidades;

public class Contato
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string ContatoDesc { get; set; } = string.Empty;
    public ETipoContato Tipo { get; set; }

    public Guid PessoaId { get; set; }
    public Pessoa Pessoa { get; set; } = null!;
}
