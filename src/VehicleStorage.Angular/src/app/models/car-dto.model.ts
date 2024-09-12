import { VehicleDto } from './vehicle-dto.model';

export interface CarDto extends VehicleDto {
  headlightState: boolean;
}
