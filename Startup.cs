
using ApiSistema.Interfaces;
using ApiSistema.Models;
using ApiSistema.Persistence.Context;
using ApiSistema.Persistence.Repositories;
using ApiSistema.Repositories;
using ApiSistema.Domain.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ApiSistema.Persistence.Repositories;
using ApiSistema.Domain.Services;

namespace ApiSistema
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();

            //var key = Encoding.ASCII.GetBytes(Settings.Secret);
            //services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //.AddJwtBearer(x =>
            //{
            //    x.RequireHttpsMetadata = false;
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(key),
            //        ValidateIssuer = false,
            //        ValidateAudience = false
            //    };
            //});


            string sqlConnection = Configuration.GetConnectionString("DefautConection");

            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();

          

            services.AddDbContext<AppDbContext>(opt =>
                                               opt.UseInMemoryDatabase("FuncionarioList"));
            //services.AddDbContext<AppDbContext>(opt =>
            //                                  opt.UseInMemoryDatabase("ApiSistema-api-in-memory"));



          

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioServices, UsuarioServices>();

            services.AddScoped<ISegurancaRepository, SegurancaRepository>();
            services.AddScoped<ISegurancaService, SegurancaServices>();

            services.AddScoped<ISegurancaItensRepository, SegurancaItensRepository>();
            services.AddScoped<ISegurancaItensService, SegurancaItensService>();

            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IEmpresaService, EmpresaService>();

            services.AddScoped<IAtividadeRepository, AtividadeRepository>();
            services.AddScoped<IAtividadeService, AtividadeService>();

            services.AddScoped<ICnaeRepository, CnaeRepository>();
            services.AddScoped<ICnaeService, CnaeService>();



            //services.AddMvcCore(options => options.EnableEndpointRouting = false).AddRazorViewEngine();
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiSistema", Version = "v1" });
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiSistema v1"));
            }

            
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
