import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TestServiceCallComponent } from './test-service-call/test-service-call.component';

import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { ViewCvComponent } from './view-cv/view-cv.component';
import { ViewCvUserHeaderComponent } from './view-cv-user-header/view-cv-user-header.component';

@NgModule({
  declarations: [
    AppComponent,
    TestServiceCallComponent,
    ViewCvComponent,
    ViewCvUserHeaderComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
