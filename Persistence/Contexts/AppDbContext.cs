using Microsoft.EntityFrameworkCore;


using ApiSistema.Models;

namespace ApiSistema.Persistence.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Seguranca> segurancas { get; set; }
        public DbSet<SegurancaItens> SegurancaItens { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<AtividadeEmpresa> atividades { get; set; }
        public DbSet<Cnae> cnaes { get; set; }
        public DbSet<Cidades> cidade { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<UF> uFs { get; set; }
        public DbSet<NfSaida> nfSaidas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BI03;Initial Catalog=BDWeb;Integrated Security=False;User ID=sa;Password=Ju250298@");
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
            string strCon = "Data Source=BI03;Initial Catalog=BDWeb;Integrated Security=False;User ID=sa;Password=Ju250298@";
            // string strCon = "Server=tcp:canaldevcore.database.windows.net,1433;Initial Catalog=dev;Persist Security Info=False;User ID=valdir;Password=@Beatriz222;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return strCon;
        }

        
    }
}
