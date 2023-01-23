import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserContactInfoComponent } from './user-contact-info.component';

describe('UserContactInfoComponent', () => {
  let component: UserContactInfoComponent;
  let fixture: ComponentFixture<UserContactInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserContactInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UserContactInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
