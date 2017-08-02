import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FlowCvEntityComponent } from './flow-cv-entity.component';

describe('FlowCvEntityComponent', () => {
  let component: FlowCvEntityComponent;
  let fixture: ComponentFixture<FlowCvEntityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FlowCvEntityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FlowCvEntityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
