using DevTech.RegistroContatos.Dados.Repositorios;
using DevTech.RegistroContatos.Dominio.Entidades;
using DevTech.RegistroContatos.Dominio.Enums;
using DevTech.RegistroContatos.Dominio.Servicos;

namespace DevTech.RegistroContatos.Dados.Servicos;

public static class ContatoServico
{
    public async static Task<Contato?> BuscarPorId(this ContatoRepositorio repositorio, Guid id)
    {
        return await BuscarPorIdServico<Contato>.Execute(repositorio, id);
    }

    public async static Task Excluir(this ContatoRepositorio repositorio, Contato obj)
    {
        await ExcluirServico<Contato>.Execute(repositorio, obj);
    }

    public async static Task<ICollection<Contato>?> Listar(this ContatoRepositorio repositorio)
    {
        return await ListarServicos<Contato>.Execute(repositorio);
    }

    public async static Task<ICollection<Contato>?> ListarPorContatoDescricao(this ContatoRepositorio repositorio, string contatoDescricao)
    {
        return await ListarServicos<Contato>.Execute(repositorio, x => x.ContatoDesc.Contains(contatoDescricao));
    }

    public async static Task<ICollection<Contato>?> ListarPorTipo(this ContatoRepositorio repositorio, ETipoContato tipo)
    {
        return await ListarServicos<Contato>.Execute(repositorio, x => x.Tipo.Equals(tipo));
    }

    public async static Task<Contato?> Salvar(this ContatoRepositorio repositorio, Contato obj)
    {
        return await SalvarServico<Contato>.Execute(repositorio, obj);
    }
}
