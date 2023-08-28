import { Component } from '@angular/core';

@Component({
  selector: 'app-temprature-converter',
  templateUrl: './temprature-converter.component.html',
  styleUrls: ['./temprature-converter.component.css'],
})
export class TempratureConverterComponent {
  temperature: number = 0;
  selectedUnit: string = 'celsius';
  convertedTemperature: number | null = null;

  convertTemperature() {
    if (this.selectedUnit === 'celsius') {
      this.convertedTemperature = ((this.temperature - 32) * 5) / 9;
    } else if (this.selectedUnit === 'fahrenheit') {
      this.convertedTemperature = (this.temperature * 9) / 5 + 32;
    }
  }
}
