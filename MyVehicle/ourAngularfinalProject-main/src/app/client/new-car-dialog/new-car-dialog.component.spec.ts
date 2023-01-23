import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewCarDialogComponent } from './new-car-dialog.component';

describe('NewCarDialogComponent', () => {
  let component: NewCarDialogComponent;
  let fixture: ComponentFixture<NewCarDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewCarDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewCarDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
