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
   public class PratoMapeamento : EntityTypeConfiguration<Prato>
    {
        public PratoMapeamento()
        {
            ToTable("Pratos");

            HasKey(x => x.Codigo)
                .Property(x => x.Codigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CodigoRestaurante)
                .IsOptional();

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(100);

            Property(x => x.Valor)
                .HasColumnName("Valor")
                .HasColumnType("Money");

        }
    }
}
