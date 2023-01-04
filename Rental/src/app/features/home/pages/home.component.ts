import { Component } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Car } from '../models/car.model';
import { CarService } from '../services/car.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass'],
})
export class HomeComponent {
  cars$: Observable<Car[]>;

  constructor(private carService: CarService) {
    this.cars$ = this.carService.get();
  }
}
