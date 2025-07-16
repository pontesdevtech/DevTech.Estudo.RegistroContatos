using DevTech.RegistroContatos.Dados.Repositorios;
using DevTech.RegistroContatos.Dados.Servicos;
using DevTech.RegistroContatos.Dominio.Entidades;
using DevTech.RegistroContatos.Dominio.Enums;

namespace DevTech.RegistroContatos.Api.Endpoints;

public static class ContatoEndpoint
{
    public static RouteGroupBuilder MapContatoEndpoints(this WebApplication app)
    {
        var grupo = app.MapGroup("/contatos").WithTags("Contatos");

        grupo.MapGet("/", async (ContatoRepositorio repositorio) =>
        {
            try
            {
                return await repositorio.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        grupo.MapGet("/contato_descricao/{contatoDesc}", async (ContatoRepositorio repositorio, string contatoDesc) =>
        {
            try
            {
                return await repositorio.ListarPorContatoDescricao(contatoDesc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        grupo.MapGet("/tipo/{tipo}", async (ContatoRepositorio repositorio, ETipoContato tipo) =>
        {
            try
            {
                return await repositorio.ListarPorTipo(tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        grupo.MapGet("/{id}", async (ContatoRepositorio repositorio, Guid id) =>
        {
            try
            {
                return await repositorio.BuscarPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        grupo.MapPost("/", async (ContatoRepositorio repositorio, Contato obj) =>
        {
            try
            {
                return await repositorio.Salvar(obj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        });

        grupo.MapDelete("/{id}", async (ContatoRepositorio repositorio, Guid id) =>
        {
            try
            {
                var obj = await repositorio.BuscarPorId(id);
                await repositorio.Excluir(obj!);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        });

        return grupo;
    }
}
