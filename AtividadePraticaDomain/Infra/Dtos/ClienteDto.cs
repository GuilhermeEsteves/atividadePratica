using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Infra.Dtos
{
    public class ClienteDto
    {
        public ClienteDto(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}