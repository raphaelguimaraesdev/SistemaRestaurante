using SistemaRestaurante.Negocio.ObjetosNegocio;
using SistemaRestaurante.Persistencia.Mapeamento;
using System;
using System.Data.Entity;

namespace SistemaRestaurante.Persistencia.Contexto
{
    public class RestauranteContexto : DbContext
    {
        public RestauranteContexto()
                : base("BaseRestaurante")
        {
            Database.SetInitializer<RestauranteContexto>
                (new AppRestauranteContextInitializer());
        }

        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Restaurante> Restaurante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            modelBuilder.Configurations.Add(new PratoMapeamento());
            modelBuilder.Configurations.Add(new RestauranteMapeamento());
            base.OnModelCreating(modelBuilder);
        }
    }
}