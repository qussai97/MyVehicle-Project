import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TaskJobDialogComponent } from './task-job-dialog.component';

describe('TaskJobDialogComponent', () => {
  let component: TaskJobDialogComponent;
  let fixture: ComponentFixture<TaskJobDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TaskJobDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TaskJobDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
