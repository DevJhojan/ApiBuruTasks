import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { TodoSimpleComponent } from './components/todo-simple/todo-simple.component';
import { TodoConstansComponent } from './components/todo-constans/todo-constans.component';


@NgModule({
  declarations: [
    TodoSimpleComponent,
    TodoConstansComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule
  ]
})
export class HomeModule { }
