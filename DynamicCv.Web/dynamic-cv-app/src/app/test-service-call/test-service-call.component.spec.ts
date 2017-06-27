import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestServiceCallComponent } from './test-service-call.component';

describe('TestServiceCallComponent', () => {
  let component: TestServiceCallComponent;
  let fixture: ComponentFixture<TestServiceCallComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestServiceCallComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestServiceCallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
