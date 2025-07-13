using DevTech.RegistroContatos.Dados.Contextos;
using DevTech.RegistroContatos.Dominio.Entidades;
using DevTech.RegistroContatos.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DevTech.RegistroContatos.Dados.Repositorios
{
    public class PessoaRepositorio(Contexto contexto) : IRepositorio<Pessoa>
    {
        private readonly Contexto _contexto = contexto;

        public async Task<Pessoa?> BuscarPorId(Guid id)
        {
            return await _contexto.Pessoas.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task Excluir(Pessoa obj)
        {
            _contexto.Pessoas.Remove(obj);
            await _contexto.SaveChangesAsync();
        }

        public async Task<ICollection<Pessoa>?> Listar()
        {
            return await _contexto.Pessoas.ToListAsync();
        }

        public async Task<ICollection<Pessoa>?> Listar(Expression<Func<Pessoa, bool>> condicao)
        {
            return await _contexto.Pessoas.Where(condicao).ToListAsync();
        }

        public async Task<Pessoa?> Salvar(Pessoa obj)
        {
            if (BuscarPorId(obj.Id) is null)
            {
                _contexto.Pessoas.Add(obj);
            }
            else
            {
                _contexto.Pessoas.Update(obj);
            }

            await _contexto.SaveChangesAsync();
            return obj;
        }

    }
}
