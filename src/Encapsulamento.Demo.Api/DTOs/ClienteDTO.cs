using Encapsulamento.Demo.Domain.Entities;

namespace Encapsulamento.Demo.Api.DTOs
{
    public class ClienteDTO
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        public static Cliente ConverterParaEntidade(ClienteDTO cliente)
        {
            return new Cliente
            (
                cliente.Codigo,
                cliente.Nome,
                cliente.DataCadastro
            );
        }
    }
}