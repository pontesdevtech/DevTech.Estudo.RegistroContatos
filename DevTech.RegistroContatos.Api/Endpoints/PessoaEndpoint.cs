using DevTech.RegistroContatos.Dados.Repositorios;
using DevTech.RegistroContatos.Dados.Servicos;
using DevTech.RegistroContatos.Dominio.Entidades;

namespace DevTech.RegistroContatos.Api.Endpoints;

public static class PessoaEndpoint
{
    public static RouteGroupBuilder MapPessoaEndpoints(this WebApplication app)
    {
        var grupo = app.MapGroup("/pessoas").WithTags("Pessoas");

        grupo.MapGet("/", async (PessoaRepositorio repositorio) =>
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

        grupo.MapGet("/nome/{nome}", async (PessoaRepositorio repositorio, string nome) =>
        {
            try
            {
                return await repositorio.ListarPorNome(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        grupo.MapGet("/cpf/{cpf}", async (PessoaRepositorio repositorio, string cpf) =>
        {
            try
            {
                return await repositorio.ListarPorCpf(cpf);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        grupo.MapGet("/data_nascimento/", async (PessoaRepositorio repositorio, DateTime dtInicio, DateTime dtTermino) =>
        {
            try
            {
                return await repositorio.ListarPorDataNascimento(dtInicio, dtTermino);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        });

        grupo.MapGet("/{id}", async (PessoaRepositorio repositorio, Guid id) =>
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

        grupo.MapPost("/", async (PessoaRepositorio repositorio, Pessoa obj) =>
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

        grupo.MapDelete("/{id}", async (PessoaRepositorio repositorio, Guid id) =>
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
