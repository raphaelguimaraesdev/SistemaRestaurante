using SistemaRestaurante.Negocio.ObjetosNegocio;
using System.ComponentModel.DataAnnotations;

namespace SistemaRestaurante.Negocio.Validacoes
{
    public class ValidacaoPrato : ValidacaoAbstrata<Prato>
    {

        public override ValidationResult ValideDados(Prato dados)
        {
            return null;
        }
    }
}