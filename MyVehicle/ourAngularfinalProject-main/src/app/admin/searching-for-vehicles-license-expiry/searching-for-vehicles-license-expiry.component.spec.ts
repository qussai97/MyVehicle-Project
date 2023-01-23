import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchingForVehiclesLicenseExpiryComponent } from './searching-for-vehicles-license-expiry.component';

describe('SearchingForVehiclesLicenseExpiryComponent', () => {
  let component: SearchingForVehiclesLicenseExpiryComponent;
  let fixture: ComponentFixture<SearchingForVehiclesLicenseExpiryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchingForVehiclesLicenseExpiryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchingForVehiclesLicenseExpiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
