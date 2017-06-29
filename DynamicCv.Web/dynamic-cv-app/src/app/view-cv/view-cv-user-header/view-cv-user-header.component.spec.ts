import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCvUserHeaderComponent } from './view-cv-user-header.component';

describe('ViewCvUserHeaderComponent', () => {
  let component: ViewCvUserHeaderComponent;
  let fixture: ComponentFixture<ViewCvUserHeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewCvUserHeaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewCvUserHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
