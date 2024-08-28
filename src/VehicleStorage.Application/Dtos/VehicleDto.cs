using AutoMapper;
using FluentValidation;
using VehicleStorage.Domain.Entities;

namespace VehicleStorage.Application.Dtos
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedDate { get; set; }
        public string ColourName { get; set; }
    }
    public class VehicleDtoValidator : AbstractValidator<VehicleDto>
    {
        public VehicleDtoValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
            RuleFor(x => x.Name).NotNull().WithMessage("Name is required");
            RuleFor(x => x.CreatedDate).NotNull().WithMessage("Created Date is required");
            RuleFor(x => x.ColourName).NotNull().WithMessage("Color Name is required");
        }
    }
}