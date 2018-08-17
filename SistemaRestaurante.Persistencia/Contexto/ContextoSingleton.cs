namespace SistemaRestaurante.Persistencia.Contexto
{
    public class ContextoSingleton
    {
        private static RestauranteContexto _instanciaContexto;

        protected ContextoSingleton()
        {
        }

        public static RestauranteContexto Instance()
        {
            if (_instanciaContexto == null)
            {
                _instanciaContexto = new RestauranteContexto();
            }

            return _instanciaContexto;
        }
    }
}