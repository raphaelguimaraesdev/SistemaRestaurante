using SistemaRestaurante.Negocio.ObjetosNegocio;
using System.Collections.Generic;

namespace SistemaRestaurante.Persistencia.Conexao
{
    public interface IConexaoBase<T>
    {
        RetornoServico Atualizar(T dados);

        RetornoServico Excluir(int codigo);

        List<T> Obtenha(string nome);

        RetornoServico Salvar(T dados);
    }
}