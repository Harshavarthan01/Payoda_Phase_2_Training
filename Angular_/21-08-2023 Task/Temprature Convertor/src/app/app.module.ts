import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { WarningAlertComponent } from './warning-alert/warning-alert.component';
import { SuccessAlertComponent } from './success-alert/success-alert.component';
import { BindingusernameComponent } from './bindingusername/bindingusername.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { TempratureConverterComponent } from './temprature-converter/temprature-converter.component';
import { MortgageInputFormComponent } from './mortgage-input-form/mortgage-input-form.component';
import { MortgageOutputFormComponent } from './mortgage-output-form/mortgage-output-form.component';

@NgModule({
  declarations: [
    AppComponent,
    WarningAlertComponent,
    SuccessAlertComponent,
    BindingusernameComponent,
    CalculatorComponent,
    TempratureConverterComponent,
    MortgageInputFormComponent,
    MortgageOutputFormComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
