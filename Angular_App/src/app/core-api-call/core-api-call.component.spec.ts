import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CoreApiCallComponent } from './core-api-call.component';

describe('CoreApiCallComponent', () => {
  let component: CoreApiCallComponent;
  let fixture: ComponentFixture<CoreApiCallComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CoreApiCallComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CoreApiCallComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
