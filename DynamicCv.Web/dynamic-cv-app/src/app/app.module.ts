import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TestServiceCallComponent } from './test-service-call/test-service-call.component';

import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { ViewCvComponent } from './view-cv/view-cv.component';
import { ViewCvUserHeaderComponent } from './view-cv/view-cv-user-header/view-cv-user-header.component';
import { ViewCvUserimageComponent } from './view-cv/view-cv-userimage/view-cv-userimage.component';
import { ViewCvUserAboutComponent } from './view-cv/view-cv-user-about/view-cv-user-about.component';

import { UserimageServiceService } from './services/userimage/userimage-service.service';
import { CvUserServiceService } from './services/cv-user-service/cv-user-service.service';
import { ViewCvEntriesComponent } from './view-cv/view-cv-entries/view-cv-entries.component';


@NgModule({
  declarations: [
    AppComponent,
    TestServiceCallComponent,
    ViewCvComponent,
    ViewCvUserHeaderComponent,
    ViewCvUserimageComponent,
    ViewCvUserAboutComponent,
    ViewCvEntriesComponent
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
