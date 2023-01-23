import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCarLicenceComponent } from './add-car-licence.component';

describe('AddCarLicenceComponent', () => {
  let component: AddCarLicenceComponent;
  let fixture: ComponentFixture<AddCarLicenceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddCarLicenceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddCarLicenceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
