namespace Encapsulamento.Demo.Domain.Entities
{
    public class Cliente
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; private set; }
        public bool Premium { get; private set; }
        public DateTime? DataPremium { get; private set; }
        public bool Ativo { get; private set; }
        public string? MotivoDesativacao { get; private set; }

        public Cliente(int codigo, string nome, DateTime dataCadastro)
        {
            Codigo = codigo;
            Nome = nome;
            DataCadastro = dataCadastro;
            Premium = false;
            Ativo = true;
        }

        public bool EhInativo() => !Ativo;

        public void TornarPremium()
        {
            Premium = true;
            DataPremium = DateTime.Now;
        }

        public void Ativar()
        {
            Ativo = true;
            MotivoDesativacao = null;
        }

        public void Desativar(string motivo)
        {
            Ativo = false;
            MotivoDesativacao = motivo;
        }
    }
}