import { TestBed } from '@angular/core/testing';

import { AutheraizationGuard } from './autheraization.guard';

describe('AutheraizationGuard', () => {
  let guard: AutheraizationGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(AutheraizationGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
