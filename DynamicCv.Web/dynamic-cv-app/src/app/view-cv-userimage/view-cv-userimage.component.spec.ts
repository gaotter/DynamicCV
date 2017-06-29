import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCvUserimageComponent } from './view-cv-userimage.component';

describe('ViewCvUserimageComponent', () => {
  let component: ViewCvUserimageComponent;
  let fixture: ComponentFixture<ViewCvUserimageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewCvUserimageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewCvUserimageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
