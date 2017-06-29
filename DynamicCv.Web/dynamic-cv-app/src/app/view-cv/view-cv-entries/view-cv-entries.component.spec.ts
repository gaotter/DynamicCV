import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCvEntriesComponent } from './view-cv-entries.component';

describe('ViewCvEntriesComponent', () => {
  let component: ViewCvEntriesComponent;
  let fixture: ComponentFixture<ViewCvEntriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewCvEntriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewCvEntriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
