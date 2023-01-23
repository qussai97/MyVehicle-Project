import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddTaskJobComponent } from './add-task-job.component';

describe('AddTaskJobComponent', () => {
  let component: AddTaskJobComponent;
  let fixture: ComponentFixture<AddTaskJobComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddTaskJobComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddTaskJobComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
