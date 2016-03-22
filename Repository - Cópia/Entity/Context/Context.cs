﻿using System.Data.Entity;
using Repository.Entity.Mapping;
using Repository.Models;

namespace Repository.Context
{
    public class Context : DbContext
    {
        public Context() : base("ConexaoDefault")
        {
            
        }

        public DbSet<Cliente> DbCliente { get; set; }
        public DbSet<Produto> DbProduto { get; set; }
        public DbSet<Pedido> DbPedido { get; set; }
        public DbSet<ItemPedido> DbItemPedido { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new ProdutoMapping());
            modelBuilder.Configurations.Add(new PedidoMapping());
            modelBuilder.Configurations.Add(new ItemPedidoMapping());
        }
    }
}
