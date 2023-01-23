import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchByVehicleCategoryComponent } from './search-by-vehicle-category.component';

describe('SearchByVehicleCategoryComponent', () => {
  let component: SearchByVehicleCategoryComponent;
  let fixture: ComponentFixture<SearchByVehicleCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchByVehicleCategoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchByVehicleCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
