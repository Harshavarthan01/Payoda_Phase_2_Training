import { Component, Input } from '@angular/core';
import { TempService } from '../temp.service';

@Component({
  selector: 'app-mortgage-output-form',
  templateUrl: './mortgage-output-form.component.html',
  styleUrls: ['./mortgage-output-form.component.css'],
})
export class MortgageOutputFormComponent {
  constructor(public temservice: TempService) {}
}
