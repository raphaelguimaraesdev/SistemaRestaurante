using System.ComponentModel.DataAnnotations;

namespace SistemaRestaurante.Negocio.ObjetosNegocio
{
    /// <summary>
    /// Classe dos dados dos pratos do restaurante.
    /// </summary>
    public class Prato
    {
        public int Codigo { get; set; }
        public int CodigoRestaurante { get; set; }
        public string Nome { get; set; }
        public virtual Restaurante Restaurante { get; set; }
        public decimal Valor { get; set; }
    }
}