using FluentValidation;

namespace VehicleStorage.Application.Dtos
{
    public class HeadlightDto
    {
        public int Id { get; set; }
    }
    public class HeadlightDtoValidator : AbstractValidator<HeadlightDto>
    {
        public HeadlightDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("Name is required"); ;
        }
    }
}