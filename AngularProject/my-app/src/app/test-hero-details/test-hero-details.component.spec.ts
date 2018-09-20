import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestHeroDetailsComponent } from './test-hero-details.component';

describe('TestHeroDetailsComponent', () => {
  let component: TestHeroDetailsComponent;
  let fixture: ComponentFixture<TestHeroDetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestHeroDetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestHeroDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
