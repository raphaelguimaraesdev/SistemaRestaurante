using SistemaRestaurante.Negocio.ObjetosNegocio;
using SistemaRestaurante.Servicos.Interface;
using System;
using System.Collections.Generic;
using SistemaRestaurante.Persistencia.Conexao;

namespace SistemaRestaurante.Servicos
{
    public class ServicoDeRestaurante : ServicoBase<Restaurante>, IServicoDeRestaurante
    {
        public Conexao<Restaurante> ConexaoBanco()
        {
            return new Conexao<Restaurante>();
        }

        public override RetornoServico Atualizar(Restaurante dados)
        {
            try
            {
                return ConexaoBanco().Atualizar(dados);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override RetornoServico Excluir(int codigo)
        {
            try
            {
                return ConexaoBanco().Excluir(codigo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override List<Restaurante> Obtenha(string nome)
        {
            try
            {
                return ConexaoBanco().Obtenha(nome);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override RetornoServico Salvar(Restaurante dados)
        {
            try
            {
                return ConexaoBanco().Salvar(dados);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}