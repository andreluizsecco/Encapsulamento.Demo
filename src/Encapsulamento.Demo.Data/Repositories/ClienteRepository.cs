using Encapsulamento.Demo.Data.Context;
using Encapsulamento.Demo.Domain.Entities;
using Encapsulamento.Demo.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Encapsulamento.Demo.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private DataContext _dataContext;

        public ClienteRepository(DataContext dataContext) =>
            _dataContext = dataContext;

        public async Task<Cliente?> ObterPorCodigo(int codigo) =>
            await _dataContext.Clientes.FindAsync(codigo);

        public async Task Adicionar(Cliente cliente) =>
            await _dataContext.AddAsync(cliente);

        public void Atualizar(Cliente cliente) =>
            _dataContext.Entry(cliente).State = EntityState.Modified;

        public async Task<bool> Commit() =>
            await _dataContext.SaveChangesAsync() > 0;
    }
}