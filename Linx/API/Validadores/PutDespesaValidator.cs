using Domain.Dtos;
using FluentValidation;

namespace API.Validadores
{   
    public class PutDespesaValidator : AbstractValidator<DespesaDto>
    {

        public PutDespesaValidator()
        {
            RuleFor(obj => obj.Id).NotEmpty().WithMessage("Id não pode ser vazio")
                   .NotNull().WithMessage("Id não pode ser nulo");

            RuleFor(x => x.IdTipoGasto).NotEmpty().WithMessage("Tipo de gasto não pode ser vazio")
                   .NotNull().WithMessage("Tipo de gasto não pode ser nulo");
            //.MaximumLength(250).WithMessage("Nome do Produto não pode ter mais de 250 caracteres");

            RuleFor(x => x.DataLancamento)                   
                   .NotEmpty().WithMessage("data da despesa não pode ser vazio")
                   .NotNull().WithMessage("data da despesa não pode ser nulo")
                   .WithMessage("A data da despesa não pode ser no passado.");

            RuleFor(obj => obj.Observacao).NotEmpty().WithMessage("Descrição do lançamento não pode ser vazio.")
                    .NotNull().WithMessage("Descrição do lançamento não pode ser nulo.")
                    .MaximumLength(20).WithMessage("Descrição do lançamento não pode ser maior do que 20 caracteres.");

            RuleFor(obj => obj.ValorLancamento)
                    .NotEmpty().WithMessage("Valor do gasto não pode ser vazio")
                    .NotNull().WithMessage("Tipo de gasto não pode ser nulo")
                    .GreaterThan(0).WithMessage("Valor do gasto deve ser maior que zero.");
        }
    }
}
