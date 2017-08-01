import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCvEntryComponent } from './view-cv-entry.component';

describe('ViewCvEntryComponent', () => {
  let component: ViewCvEntryComponent;
  let fixture: ComponentFixture<ViewCvEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewCvEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewCvEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
