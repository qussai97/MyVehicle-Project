import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetTaskJobComponent } from './get-task-job.component';

describe('GetTaskJobComponent', () => {
  let component: GetTaskJobComponent;
  let fixture: ComponentFixture<GetTaskJobComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetTaskJobComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetTaskJobComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
