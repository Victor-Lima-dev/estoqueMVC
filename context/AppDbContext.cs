using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using estoqueMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace estoqueMVC.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<ItemEstoque> ItensEstoque { get; set; }    
    }
}