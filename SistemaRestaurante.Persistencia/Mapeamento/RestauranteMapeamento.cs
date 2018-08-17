using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Negocio.ObjetosNegocio;

namespace SistemaRestaurante.Persistencia.Mapeamento
{
   public class RestauranteMapeamento : EntityTypeConfiguration<Restaurante>
    {
        public RestauranteMapeamento()
        {
            ToTable("Restaurantes");

            HasKey(x => x.Codigo)
                .Property(x => x.Codigo)
                .HasColumnName("Codigo")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
                .HasMaxLength(100);

            HasMany(p => p.Pratos)
                .WithOptional(po => po.Restaurante)
                .HasForeignKey(p => p.CodigoRestaurante);


        }
    }
}
