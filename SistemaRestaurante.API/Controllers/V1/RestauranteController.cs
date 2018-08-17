using Microsoft.AspNetCore.Mvc;
using SistemaRestaurante.Negocio.ObjetosNegocio;
using System.Collections.Generic;

namespace SistemaRestaurante.API.Controllers.V1
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:ApiVersion}/Controller")]
    public class RestauranteController : ControladorAbstrato<Restaurante>
    {
        [HttpDelete("{codigo}")]
        public override void Excluir(int codigo)
        {
        }

        [HttpGet("{nome}")]
        public override Restaurante Obtenha(string nome)
        {
            return null;
        }
    }
}