import { Vehicle } from './vehicle.model';

export interface Colour {
  id: number;
  colorName: string;
  products: Vehicle[];
}
