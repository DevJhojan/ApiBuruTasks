import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Error404Component } from './components/error-404/error-404.component';



@NgModule({
  declarations: [
    Error404Component
  ],
  exports: [
    Error404Component
  ],
  imports: [
    CommonModule
  ]
})
export class SharedModule { }
