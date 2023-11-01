import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutAuthComponent } from '../layouts';
import { LogInComponent } from './components/log-in/log-in.component';
import { SigUpComponent } from './components/sig-up/sig-up.component';



const routes: Routes = [
  {
    path: '',
    component: LayoutAuthComponent,
    children:[
      {path: 'login', component: LogInComponent},
      {path: 'sigup', component: SigUpComponent},
      {path: '**', redirectTo: 'login'}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthRoutingModule { }
