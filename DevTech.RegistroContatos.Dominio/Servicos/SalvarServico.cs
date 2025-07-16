using DevTech.RegistroContatos.Dominio.Interfaces;

namespace DevTech.RegistroContatos.Dominio.Servicos;

public static class SalvarServico <T> where T : class
{
    public static async Task<T?> Execute(IRepositorio<T> repositorio, T obj)
    {
        return await repositorio.Salvar(obj);
    }
}
