using DevTech.RegistroContatos.Dominio.Interfaces;

namespace DevTech.RegistroContatos.Dominio.Servicos;

public static class BuscarPorIdServico<T> where T : class
{
    public static async Task<T?> Execute(IRepositorio<T> repositorio, Guid id)
    {
        return await repositorio.BuscarPorId(id);
    }
}
