import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewBankcardComponent } from './view-bankcard.component';

describe('ViewBankcardComponent', () => {
  let component: ViewBankcardComponent;
  let fixture: ComponentFixture<ViewBankcardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewBankcardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewBankcardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
