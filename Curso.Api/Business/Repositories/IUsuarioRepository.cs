using Curso.Api.Business.Entities;

namespace Curso.Api.Business.Repositories
{
    interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();
    }
}
