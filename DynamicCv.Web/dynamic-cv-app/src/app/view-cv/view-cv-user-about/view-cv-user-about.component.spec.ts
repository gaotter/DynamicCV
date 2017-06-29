import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCvUserAboutComponent } from './view-cv-user-about.component';

describe('CvUserAboutComponent', () => {
  let component: ViewCvUserAboutComponent;
  let fixture: ComponentFixture<ViewCvUserAboutComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewCvUserAboutComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewCvUserAboutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
