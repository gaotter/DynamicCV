import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TestServiceCallComponent } from './test-service-call/test-service-call.component';

import { RouterModule, Routes } from '@angular/router';

import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { ViewCvComponent } from './view-cv/view-cv.component';
import { ViewCvUserHeaderComponent } from './view-cv/view-cv-user-header/view-cv-user-header.component';
import { ViewCvUserimageComponent } from './view-cv/view-cv-userimage/view-cv-userimage.component';
import { ViewCvUserAboutComponent } from './view-cv/view-cv-user-about/view-cv-user-about.component';

import { UserimageServiceService } from './services/userimage/userimage-service.service';
import { CvUserServiceService } from './services/cv-user-service/cv-user-service.service';
import { DateTimeService } from './services/helpers/date-time.service';

import { ViewCvEntriesComponent } from './view-cv/view-cv-entries/view-cv-entries.component';
import { UserLoginComponent } from './user-login/user-login.component';
import { ViewCvEntryComponent } from './view-cv/view-cv-entry/view-cv-entry.component';
import { FlowCvEntityComponent } from './flow-cv/flow-cv-entity/flow-cv-entity.component';
import { EditCvEntryComponent } from './edit-cv/edit-cv-entry/edit-cv-entry.component';


const appRoutes: Routes = [
  { path: 'login', component: UserLoginComponent },
  {
    path:'', component:ViewCvComponent 
  }

];


@NgModule({
  declarations: [
    AppComponent,
    TestServiceCallComponent,
    ViewCvComponent,
    ViewCvUserHeaderComponent,
    ViewCvUserimageComponent,
    ViewCvUserAboutComponent,
    ViewCvEntriesComponent,
    UserLoginComponent,
    ViewCvEntryComponent,
    FlowCvEntityComponent,
    EditCvEntryComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
  ],
  providers: [UserimageServiceService, CvUserServiceService, DateTimeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
