import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TestServiceCallComponent } from './test-service-call/test-service-call.component';

import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { ViewCvComponent } from './view-cv/view-cv.component';
import { ViewCvUserHeaderComponent } from './view-cv-user-header/view-cv-user-header.component';
import { ViewCvUserimageComponent } from './view-cv-userimage/view-cv-userimage.component';
import { UserimageServiceService } from './services/userimage/userimage-service.service';
import { CvUserServiceService } from './services/cv-user-service/cv-user-service.service';
import { CvUserAboutComponent } from './cv-user-about/cv-user-about.component';

@NgModule({
  declarations: [
    AppComponent,
    TestServiceCallComponent,
    ViewCvComponent,
    ViewCvUserHeaderComponent,
    ViewCvUserimageComponent,
    CvUserAboutComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [UserimageServiceService, CvUserServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
