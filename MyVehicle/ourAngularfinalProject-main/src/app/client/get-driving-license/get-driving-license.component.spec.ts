import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetDrivingLicenseComponent } from './get-driving-license.component';

describe('GetDrivingLicenseComponent', () => {
  let component: GetDrivingLicenseComponent;
  let fixture: ComponentFixture<GetDrivingLicenseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetDrivingLicenseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetDrivingLicenseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
