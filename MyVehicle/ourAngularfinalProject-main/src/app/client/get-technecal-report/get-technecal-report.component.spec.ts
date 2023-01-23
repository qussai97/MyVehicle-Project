import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetTechnecalReportComponent } from './get-technecal-report.component';

describe('GetTechnecalReportComponent', () => {
  let component: GetTechnecalReportComponent;
  let fixture: ComponentFixture<GetTechnecalReportComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetTechnecalReportComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetTechnecalReportComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
