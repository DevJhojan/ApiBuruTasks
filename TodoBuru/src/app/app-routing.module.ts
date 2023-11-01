import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { Error404Component } from "./shared/components/error-404/error-404.component";

const routes: Routes = [
  {path: '', redirectTo: 'Todo', pathMatch:'full'},
  {
    path: 'auth', title: 'Bienvenido TodoBuru',
    loadChildren:() => import('./auth/auth.module').then(m=> m.AuthModule)
  },
  {
    path: 'Todo',
    title: 'Buru',
    loadChildren:()=> import('./home/home.module').then(m=>m.HomeModule)
  },
  {path: '404', component: Error404Component},
  { path: '**', redirectTo: '404'}
]
@NgModule({
  imports: [
    RouterModule.forRoot(routes),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
