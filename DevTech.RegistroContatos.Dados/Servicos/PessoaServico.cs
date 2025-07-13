using DevTech.RegistroContatos.Dados.Repositorios;
using DevTech.RegistroContatos.Dominio.Entidades;
using DevTech.RegistroContatos.Dominio.Servicos;

namespace DevTech.RegistroContatos.Dados.Servicos;

public static class PessoaServico
{
    public async static Task<Pessoa?> BuscarPorId(this PessoaRepositorio repositorio, Guid id)
    {
        return await BuscarPorIdServico<Pessoa>.Execute(repositorio, id);
    }

    public async static Task Excluir(this PessoaRepositorio repositorio, Pessoa obj)
    {
        await ExcluirServico<Pessoa>.Execute(repositorio, obj);
    }

    public async static Task<ICollection<Pessoa>?> Listar(this PessoaRepositorio repositorio)
    {
        return await ListarServicos<Pessoa>.Execute(repositorio);
    }

    public async static Task<ICollection<Pessoa>?> ListarPorNome(this PessoaRepositorio repositorio, string nome)
    {
        return await ListarServicos<Pessoa>.Execute(repositorio, x => x.Nome.Contains(nome));
    }

    public async static Task<ICollection<Pessoa>?> ListarPorCpf(this PessoaRepositorio repositorio, string cpf)
    {
        return await ListarServicos<Pessoa>.Execute(repositorio, x => x.Cpf.Contains(cpf));
    }

    public async static Task<ICollection<Pessoa>?> ListarPorDataNascimento(this PessoaRepositorio repositorio, DateTime dtInicial, DateTime dtFinal)
    {
        return await ListarServicos<Pessoa>.Execute(repositorio, x => x.DtNascimento >= dtInicial && x.DtNascimento <= dtFinal);
    }

    public async static Task<Pessoa?> Salvar(this PessoaRepositorio repositorio, Pessoa obj)
    {
        return await SalvarServico<Pessoa>.Execute(repositorio, obj);
    }
}
