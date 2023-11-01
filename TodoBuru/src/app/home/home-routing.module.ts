import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutHomeComponent } from '../layouts';
import { TodoSimpleComponent } from './components/todo-simple/todo-simple.component';
import { TodoConstansComponent } from './components/todo-constans/todo-constans.component';

const routes: Routes = [
  {
    path: '',
    component: LayoutHomeComponent,
    children: [
      {path: 'BuruSimple', component: TodoSimpleComponent},
      {path: 'BuruConstant', component:TodoConstansComponent},
      {path: '**', redirectTo: 'BuruSimple'}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
