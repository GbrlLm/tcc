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
        public DbSet<AuthModel> Auth { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AvaliacaoModel>(entity => entity.HasKey("cd_avaliacao"));
            modelBuilder.Entity<UsuarioModel>(entity => entity.HasKey("cd_usuario"));
            modelBuilder.Entity<CategoriaModel>(entity => entity.HasKey("cd_categoria"));
            modelBuilder.Entity<CorModel>(entity => entity.HasKey("cd_cor"));
            modelBuilder.Entity<EnderecoModel>(entity => entity.HasKey("cd_endereco"));
            modelBuilder.Entity<PedidoModel>(entity => entity.HasKey("cd_pedido"));
            modelBuilder.Entity<ProdutoModel>(entity => entity.HasKey("cd_produto"));
            modelBuilder.Entity<ProdutoVendaModel>(entity => entity.HasKey("cd_produto_venda"));
            modelBuilder.Entity<StatusModel>(entity => entity.HasKey("cd_status"));
            modelBuilder.Entity<TamanhoModel>(entity => entity.HasKey("cd_tamanho"));
            modelBuilder.Entity<PedidoProdutoModel>(entity => entity.HasKey("cd_pedido", "cd_produto_venda"));
            modelBuilder.Entity<AuthModel>(entity => entity.HasKey("cd_auth"));
        }
    }
}
