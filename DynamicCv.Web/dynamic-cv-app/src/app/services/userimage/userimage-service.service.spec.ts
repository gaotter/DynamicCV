import { TestBed, inject } from '@angular/core/testing';

import { UserimageServiceService } from './userimage-service.service';

describe('UserimageServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [UserimageServiceService]
    });
  });

  it('should be created', inject([UserimageServiceService], (service: UserimageServiceService) => {
    expect(service).toBeTruthy();
  }));
});
