import { Component, Input } from '@angular/core';
import { Car } from '../../models/car.model';

@Component({
  selector: 'car-tile',
  templateUrl: './car-tile.component.html',
  styleUrls: ['./car-tile.component.sass'],
})
export class CarTileComponent {
  @Input() car!: Car;

  constructor() {}
}
