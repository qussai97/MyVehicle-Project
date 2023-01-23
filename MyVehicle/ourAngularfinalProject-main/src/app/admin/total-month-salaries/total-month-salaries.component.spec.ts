import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TotalMonthSalariesComponent } from './total-month-salaries.component';

describe('TotalMonthSalariesComponent', () => {
  let component: TotalMonthSalariesComponent;
  let fixture: ComponentFixture<TotalMonthSalariesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TotalMonthSalariesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TotalMonthSalariesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
