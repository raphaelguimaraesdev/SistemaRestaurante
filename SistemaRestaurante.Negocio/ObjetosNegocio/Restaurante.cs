using System.Collections.Generic;

namespace SistemaRestaurante.Negocio.ObjetosNegocio
{
    public class Restaurante
    {
        public Restaurante()
        {
            Pratos = new List<Prato>();
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Prato> Pratos { get; set; }
    }
}