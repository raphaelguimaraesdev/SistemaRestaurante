using SistemaRestaurante.Negocio.ObjetosNegocio;
using SistemaRestaurante.Servicos.Interface;
using System.Collections.Generic;

namespace SistemaRestaurante.Servicos
{
    public abstract class ServicoBase<T> : IServicoBase<T>
    {
        public abstract RetornoServico Atualizar(T dados);

        public abstract RetornoServico Excluir(int codigo);

        public abstract List<T> Obtenha(string nome);

        public abstract RetornoServico Salvar(T dados);
    }
}