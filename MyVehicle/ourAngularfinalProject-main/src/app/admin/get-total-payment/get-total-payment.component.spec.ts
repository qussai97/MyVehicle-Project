import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetTotalPaymentComponent } from './get-total-payment.component';

describe('GetTotalPaymentComponent', () => {
  let component: GetTotalPaymentComponent;
  let fixture: ComponentFixture<GetTotalPaymentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetTotalPaymentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetTotalPaymentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
