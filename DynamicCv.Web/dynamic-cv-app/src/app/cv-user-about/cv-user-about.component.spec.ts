import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CvUserAboutComponent } from './cv-user-about.component';

describe('CvUserAboutComponent', () => {
  let component: CvUserAboutComponent;
  let fixture: ComponentFixture<CvUserAboutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CvUserAboutComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CvUserAboutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
