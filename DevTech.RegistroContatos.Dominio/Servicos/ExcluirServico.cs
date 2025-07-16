using DevTech.RegistroContatos.Dominio.Interfaces;

namespace DevTech.RegistroContatos.Dominio.Servicos;

public static class ExcluirServico<T> where T : class
{
    public static async Task Execute(IRepositorio<T> repositorio, T obj)
    {
        await repositorio.Excluir(obj);
    }
}
