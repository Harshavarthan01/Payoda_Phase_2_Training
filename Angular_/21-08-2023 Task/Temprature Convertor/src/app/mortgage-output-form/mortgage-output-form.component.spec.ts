import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MortgageOutputFormComponent } from './mortgage-output-form.component';

describe('MortgageOutputFormComponent', () => {
  let component: MortgageOutputFormComponent;
  let fixture: ComponentFixture<MortgageOutputFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MortgageOutputFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MortgageOutputFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
