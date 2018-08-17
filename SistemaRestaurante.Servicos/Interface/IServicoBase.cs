using SistemaRestaurante.Negocio.ObjetosNegocio;
using System.Collections.Generic;

namespace SistemaRestaurante.Servicos.Interface
{
    public interface IServicoBase<T>
    {
        RetornoServico Atualizar(T dados);

        RetornoServico Excluir(int codigo);

        List<T> Obtenha(string nome);

        RetornoServico Salvar(T dados);
    }
}