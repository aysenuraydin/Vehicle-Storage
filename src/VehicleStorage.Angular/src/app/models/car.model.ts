import { Vehicle } from './vehicle.model';
import { HeadlightStatus } from './enums/headlight-status.enum';

export interface Car extends Vehicle {
  wheels: number;
  headlights: HeadlightStatus;
}
