using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SistemaRestaurante.Negocio.Validacoes
{
    public abstract class ValidacaoAbstrata<T> : AbstractValidator<T> where T: class
    {
        public abstract ValidationResult ValideDados(T dados);
    }
}
