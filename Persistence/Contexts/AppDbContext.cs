using Microsoft.EntityFrameworkCore;
using ApiCro.Models;
using ApiCro.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ApiCro.Persistence.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
      
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Departamentos> departamento { get; set; }
        public DbSet<CaixaRotativo> caixaRotativo { get; set; }
        public DbSet<CaixaCab> caixaCabs { get; set; }
        public DbSet<CaixaItens> caixaItens { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Seguranca> segurancas { get; set; }
        public DbSet<Permissoes> permissao { get; set; }
        public DbSet<CadastroBI> cadastroBIs { get; set; }
        public DbSet<SegurancaItens> SegurancaItens { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define o provedor do BD e a string de conexão
            optionsBuilder.UseSqlServer("Data Source=BI03;Initial Catalog=BDTencel;Integrated Security=False;User ID=sa;Password=Ju250298@");
            //exibe as consultas SQL no console
            //optionsBuilder
            //    .EnableSensitiveDataLogging(true)
            //    .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) =>
            //    level == LogLevel.Information &&
            //    category == DbLoggerCategory.Database.Command.Name, true));
        }
       

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);

            //builder.Entity<Usuario>().ToTable("tUsuario");
            //builder.Entity<Usuario>().HasKey(p => p.ID);
            //builder.Entity<Usuario>().Property(p => p.ID).IsRequired().ValueGeneratedOnAdd();
            //builder.Entity<Usuario>().Property(p => p.Nome).IsRequired().HasMaxLength(50);
            //builder.Entity<Usuario>().Property(p => p.Senha).IsRequired().HasMaxLength(10);
            //builder.Entity<Usuario>().Property(p => p.Email).IsRequired().HasMaxLength(20);
            //builder.Entity<Usuario>().Property(p => p.Master).IsRequired();
            //builder.Entity<Usuario>().Property(p => p.DeptoID).IsRequired();
            //builder.Entity<Usuario>().Property(p => p.Inativo).IsRequired();
            //builder.Entity<Usuario>().HasMany
            //    (p => p.departamentos).WithOne(p => p.usuario).HasForeignKey(p => p.ID);

            //builder.Entity<Departamentos>().ToTable("tDepartamento");
            //builder.Entity<Departamentos>().HasKey(p => p.ID);
            //builder.Entity<Departamentos>().HasKey(p => p.Departamento);


            //builder.Entity<CaixaCab>().ToTable("tCaixaCab");
            //builder.Entity<CaixaCab>().HasKey(p => p.Id);
            //builder.Entity<CaixaCab>().HasKey(p => p.tUsuarioId);
            //builder.Entity<CaixaCab>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            //builder.Entity<CaixaCab>().Property(p => p.MesAno).IsRequired().HasMaxLength(10);
            //builder.Entity<CaixaCab>().Property(p => p.NomeCaixa).IsRequired().HasMaxLength(50);





            //builder.Entity<CaixaCab>(entity =>
            //{
            //    entity
            //    entity.HasKey(e => new { e.tUsuarioId, e.Usuario.ID });
            //});
        }
        
        private string stringConexao()
        {
            string strCon = "Data Source=BI03;Initial Catalog=BDTencel;Integrated Security=False;User ID=sa;Password=Ju250298@";
            // string strCon = "Server=tcp:canaldevcore.database.windows.net,1433;Initial Catalog=dev;Persist Security Info=False;User ID=valdir;Password=@Beatriz222;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return strCon;
        }

        
    }
}
