using SistemaRestaurante.Negocio.ObjetosNegocio;
using SistemaRestaurante.Servicos.Interface;
using System;
using System.Collections.Generic;
using SistemaRestaurante.Persistencia.Conexao;

namespace SistemaRestaurante.Servicos
{
    public class ServicoDePrato : ServicoBase<Prato>, IServicoDePrato
    {
        public Conexao<Prato> ConexaoBanco()
        {
            return new Conexao<Prato>();
        }

        public override RetornoServico Atualizar(Prato dados)
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

        public override List<Prato> Obtenha(string nome)
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

        public override RetornoServico Salvar(Prato dados)
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