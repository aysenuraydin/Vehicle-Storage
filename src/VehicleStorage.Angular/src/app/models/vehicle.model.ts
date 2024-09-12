import { Colour } from './colour.model';

export interface Vehicle {
  id: number;
  name: string;
  createdDate: Date;
  colourId: number;
  colourFk?: Colour;
}
