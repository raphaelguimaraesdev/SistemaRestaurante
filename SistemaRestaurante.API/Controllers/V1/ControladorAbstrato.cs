using Microsoft.AspNetCore.Mvc;

namespace SistemaRestaurante.API.Controllers.V1
{
    public abstract class ControladorAbstrato<T> : Controller
    {
        public abstract void Excluir(int codigo);
        public abstract T Obtenha(string nome);
    }
}