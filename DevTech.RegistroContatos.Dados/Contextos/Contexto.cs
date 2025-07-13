using DevTech.RegistroContatos.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DevTech.RegistroContatos.Dados.Contextos;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }
}
