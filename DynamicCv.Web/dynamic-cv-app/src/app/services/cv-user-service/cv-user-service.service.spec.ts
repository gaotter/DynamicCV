import { TestBed, inject } from '@angular/core/testing';

import { CvUserServiceService } from './cv-user-service.service';

describe('CvUserServiceService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CvUserServiceService]
    });
  });

  it('should be created', inject([CvUserServiceService], (service: CvUserServiceService) => {
    expect(service).toBeTruthy();
  }));
});
