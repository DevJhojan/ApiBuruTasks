import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TodoConstansComponent } from './todo-constans.component';

describe('TodoConstansComponent', () => {
  let component: TodoConstansComponent;
  let fixture: ComponentFixture<TodoConstansComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TodoConstansComponent]
    });
    fixture = TestBed.createComponent(TodoConstansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
