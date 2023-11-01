import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SigUpComponent } from './sig-up.component';

describe('SigUpComponent', () => {
  let component: SigUpComponent;
  let fixture: ComponentFixture<SigUpComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SigUpComponent]
    });
    fixture = TestBed.createComponent(SigUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
