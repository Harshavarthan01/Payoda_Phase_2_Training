import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Task1Project';
  loanAmount: number = 0;
  monthlyPayment: number = 0;

  setCalculatedValues(values: {
    loanAmount: number;
    monthlyPayment: number;
  }): void {
    this.loanAmount = values.loanAmount;
    this.monthlyPayment = values.monthlyPayment;
  }
}
