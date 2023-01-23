import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VehicleSystemReportBetweenComponent } from './vehicle-system-report-between.component';

describe('VehicleSystemReportBetweenComponent', () => {
  let component: VehicleSystemReportBetweenComponent;
  let fixture: ComponentFixture<VehicleSystemReportBetweenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VehicleSystemReportBetweenComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VehicleSystemReportBetweenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
