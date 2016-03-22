using System.Collections.Generic;

namespace AtividadePraticaDomain.Models
{
    public class Cliente : BaseModel
    {
        public Cliente()
        {
            
        }

        public Cliente(string nome, decimal cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public string Nome { get; set; }

        public decimal Cpf { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }  
    }
}
