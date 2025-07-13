using DevTech.RegistroContatos.Dominio.Interfaces;
using System.Linq.Expressions;

namespace DevTech.RegistroContatos.Dominio.Servicos;

public static class ListarServicos<T> where T : class 
{
    public static async Task<ICollection<T>> Listar(IRepositorio<T> repositorio)
    {
        return await repositorio.Listar();
    }

    public static async Task<ICollection<T>> Listar(IRepositorio<T> repositorio, Expression<Func<T, bool>> condicao)
    {
        return await repositorio.Listar(condicao);
    }
}
