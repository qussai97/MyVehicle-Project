import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LicencingComponent } from './licencing.component';

describe('LicencingComponent', () => {
  let component: LicencingComponent;
  let fixture: ComponentFixture<LicencingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LicencingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LicencingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
