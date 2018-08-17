using SistemaRestaurante.Negocio.ObjetosNegocio;
using SistemaRestaurante.Persistencia.Contexto;
using System;
using System.Collections.Generic;

namespace SistemaRestaurante.Persistencia.Conexao
{
    public class Conexao<T> : IConexaoBase<T>
    {
        public RetornoServico Atualizar(T dados)
        {
            try
            {
                using (RestauranteContexto contexto = ContextoSingleton.Instance())
                {
                    return ObtenhaRetornoServico(true);
                }
            }
            catch (Exception)
            {
                return ObtenhaRetornoServico(false);
                throw;
            }
        }

        public RetornoServico Excluir(int codigo)
        {
            try
            {
                using (RestauranteContexto contexto = ContextoSingleton.Instance())
                {
                    return ObtenhaRetornoServico(true);
                }
            }
            catch (Exception)
            {
                return ObtenhaRetornoServico(false);
                throw;
            }
        }

        public List<T> Obtenha(string nome)
        {
            try
            {
                using (RestauranteContexto contexto = ContextoSingleton.Instance())
                {
                    return new List<T>();
                }
            }
            catch (Exception)
            {
                return new List<T>();
                throw;
            }
        }

        public RetornoServico Salvar(T dados)
        {
            try
            {
                using (RestauranteContexto contexto = ContextoSingleton.Instance())
                {
                    return ObtenhaRetornoServico(true);
                }
            }
            catch (Exception)
            {
                return ObtenhaRetornoServico(false);
                throw;
            }
        }

        private RetornoServico ObtenhaRetornoServico(bool sucesso)
        {
            return new RetornoServico(true);
        }
    }
}