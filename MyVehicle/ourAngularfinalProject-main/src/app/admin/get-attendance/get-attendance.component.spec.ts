import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetAttendanceComponent } from './get-attendance.component';

describe('GetAttendanceComponent', () => {
  let component: GetAttendanceComponent;
  let fixture: ComponentFixture<GetAttendanceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetAttendanceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetAttendanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
