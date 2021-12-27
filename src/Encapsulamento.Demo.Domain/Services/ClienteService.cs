using Encapsulamento.Demo.Domain.Entities;
using Encapsulamento.Demo.Domain.Interfaces.Repositories;
using Encapsulamento.Demo.Domain.Interfaces.Services;

namespace Encapsulamento.Demo.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) =>
            _clienteRepository = clienteRepository;

        public async Task<Cliente?> ObterClientePorCodigo(int codigo) =>
            await _clienteRepository.ObterPorCodigo(codigo);

        public async Task InserirCliente(Cliente cliente)
        {
            await _clienteRepository.Adicionar(cliente);
            await _clienteRepository.Commit();
        }

        public async Task TornarClientePremium(int codigo)
        {
            var cliente = await _clienteRepository.ObterPorCodigo(codigo);
            if (cliente == null)
                throw new Exception("Cliente não encontrado.");
            
            if (cliente.EhInativo())
            {
                // Protegendo as propriedades da sua entidade, você se protege de alterações
                // não permitidas e que não possui um comportamento previamente criado para isso.
                // Dessa forma você obriga as entidades encapsularem seus próprios comportamentos, sem expor seu estado diretamente para outros clientes alterarem.
                // cliente.Ativo = true;
                // cliente.Ativar();
            }
            cliente.TornarPremium();
            _clienteRepository.Atualizar(cliente);
            await _clienteRepository.Commit();
        }

        public async Task DesativarCliente(int codigo, string motivo)
        {
            var cliente = await _clienteRepository.ObterPorCodigo(codigo);
            if (cliente == null)
                throw new Exception("Cliente não encontrado.");
            cliente.Desativar(motivo);
            _clienteRepository.Atualizar(cliente);
            await _clienteRepository.Commit();
        }
    }
}