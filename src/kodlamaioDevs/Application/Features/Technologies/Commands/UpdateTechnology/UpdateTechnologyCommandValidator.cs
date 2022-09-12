using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Commands.UpdateTechnology
{
    public class UpdateTechnologyCommandValidator: AbstractValidator<UpdateTechnologyCommand>
    {
        public UpdateTechnologyCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.ProgrammingLanguageId).NotEmpty();
            RuleFor(p => p.Name).NotEmpty();
        }
    }
}
