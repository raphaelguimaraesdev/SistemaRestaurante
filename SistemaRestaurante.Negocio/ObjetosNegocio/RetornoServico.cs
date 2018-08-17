using System;
using System.Collections.Generic;

namespace SistemaRestaurante.Negocio.ObjetosNegocio
{
    /// <summary>
    /// Classe responsável pelo dados do retorno do serviço.
    /// </summary>
    public class RetornoServico
    {
        public RetornoServico(bool existeConsistencia, List<string> listaInconsistencia)
        {
            this.ExisteConsistencia = existeConsistencia;
            this.ListaInconsistencia = listaInconsistencia;
        }

        public RetornoServico(bool existeConsistencia)
        {
            this.ExisteConsistencia = existeConsistencia;
            this.ListaInconsistencia = new List<string>();
        }

        public bool ExisteConsistencia { get; set; }
        public ICollection<String> ListaInconsistencia { get; set; }
    }
}