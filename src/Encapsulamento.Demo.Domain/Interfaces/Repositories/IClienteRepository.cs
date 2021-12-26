using Encapsulamento.Demo.Domain.Entities;

namespace Encapsulamento.Demo.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente?> ObterPorCodigo(int codigo);
        Task Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        Task<bool> Commit();
    }
}