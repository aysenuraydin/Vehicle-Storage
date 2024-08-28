using AutoMapper;
using FluentValidation;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Application.Dtos
{
    public class ColourDto
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
    public class ColourDtoValidator : AbstractValidator<ColourDto>
    {
        public ColourDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
            RuleFor(x => x.ColorName).NotNull().WithMessage("Color Name is required");
        }
    }
}