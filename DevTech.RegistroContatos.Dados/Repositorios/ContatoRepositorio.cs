using DevTech.RegistroContatos.Dados.Contextos;
using DevTech.RegistroContatos.Dominio.Entidades;
using DevTech.RegistroContatos.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DevTech.RegistroContatos.Dados.Repositorios
{
    public class ContatoRepositorio(Contexto contexto) : IRepositorio<Contato>
    {
        private readonly Contexto _contexto = contexto;

        public async Task<Contato?> BuscarPorId(Guid id)
        {
            return await _contexto.Contatos.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task Excluir(Contato obj)
        {
            _contexto.Contatos.Remove(obj);
            await _contexto.SaveChangesAsync();
        }

        public async Task<ICollection<Contato>?> Listar()
        {
            return await _contexto.Contatos.ToListAsync();
        }

        public async Task<ICollection<Contato>?> Listar(Expression<Func<Contato, bool>> condicao)
        {
            return await _contexto.Contatos.Where(condicao).ToListAsync();
        }

        public async Task<Contato?> Salvar(Contato obj)
        {
            if (BuscarPorId(obj.Id) is null)
            {
                _contexto.Contatos.Add(obj);
            }
            else
            {
                _contexto.Contatos.Update(obj);
            }

            await _contexto.SaveChangesAsync();
            return obj;
        }

    }
}
