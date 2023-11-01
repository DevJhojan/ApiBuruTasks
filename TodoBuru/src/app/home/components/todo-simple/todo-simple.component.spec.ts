import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TodoSimpleComponent } from './todo-simple.component';

describe('TodoSimpleComponent', () => {
  let component: TodoSimpleComponent;
  let fixture: ComponentFixture<TodoSimpleComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TodoSimpleComponent]
    });
    fixture = TestBed.createComponent(TodoSimpleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
