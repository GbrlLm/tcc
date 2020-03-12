using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Common.Context
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AvaliacaoModel> Avaliacoes { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }
        public DbSet<CorModel> Cores { get; set; }
        public DbSet<EnderecoModel> Enderecos { get; set; }
        public DbSet<PedidoModel> Pedidos { get; set; }
        public DbSet<PedidoProdutoModel> PedidosProdutos { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<ProdutoVendaModel> ProdutosVendas { get; set; }
        public DbSet<StatusModel> Status { get; set; }
        public DbSet<TamanhoModel> Tamanhos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
