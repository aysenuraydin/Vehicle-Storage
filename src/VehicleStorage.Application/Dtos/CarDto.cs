using AutoMapper;
using FluentValidation;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Application.Dtos
{
    public class CarDto : VehicleDto
    {
        public bool HeadlightState { get; set; }
    }
    public class CarDtoValidator : AbstractValidator<CarDto>
    {
        public CarDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
            RuleFor(x => x.Name).NotNull().WithMessage("Name is required");
            RuleFor(x => x.CreatedDate).NotNull().WithMessage("Created Date is required");
            RuleFor(x => x.ColourName).NotNull().WithMessage("Color Name is required");
        }
    }
}