import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { LayoutAuthComponent, LayoutHomeComponent } from './layouts';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    LayoutAuthComponent,
    LayoutHomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  exports:[
    LayoutAuthComponent,
    LayoutHomeComponent,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
