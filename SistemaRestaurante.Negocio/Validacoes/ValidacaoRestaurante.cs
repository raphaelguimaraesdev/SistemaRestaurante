using System.ComponentModel.DataAnnotations;
using SistemaRestaurante.Negocio.ObjetosNegocio;

namespace SistemaRestaurante.Negocio.Validacoes
{
    public class ValidacaoRestaurante : ValidacaoAbstrata<Restaurante>
    {
        public override ValidationResult ValideDados(Restaurante dados)
        {
            return null;
        }
    }
}