import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditCvEntryComponent } from './edit-cv-entry.component';

describe('EditCvEntryComponent', () => {
  let component: EditCvEntryComponent;
  let fixture: ComponentFixture<EditCvEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditCvEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditCvEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
