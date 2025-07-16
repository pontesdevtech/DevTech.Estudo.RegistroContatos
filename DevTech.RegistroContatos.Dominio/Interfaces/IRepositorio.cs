using System.Linq.Expressions;

namespace DevTech.RegistroContatos.Dominio.Interfaces;

public interface IRepositorio <T> where T : class
{
    Task<ICollection<T>?> Listar();
    Task<ICollection<T>?> Listar(Expression<Func<T, bool>> condicao);
    Task<T?> BuscarPorId(Guid id);
    Task<T?> Salvar(T obj);
    Task Excluir(T obj);
}
