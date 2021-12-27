using Encapsulamento.Demo.Domain.Entities;

namespace Encapsulamento.Demo.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Task<Cliente?> ObterClientePorCodigo(int codigo);
        Task InserirCliente(Cliente cliente);
        Task TornarClientePremium(int codigo);
        Task DesativarCliente(int codigo, string motivo);
    }
}