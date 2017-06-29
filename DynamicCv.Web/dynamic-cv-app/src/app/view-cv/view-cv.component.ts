import { Component, OnInit } from '@angular/core';

import { CvUserServiceService } from './../services/cv-user-service/cv-user-service.service';
import { ICvUser, initICvUser } from './../interfaces/i-user';

@Component({
  selector: 'app-view-cv',
  templateUrl: './view-cv.component.html',
  styleUrls: ['./view-cv.component.css']
})
export class ViewCvComponent implements OnInit {

  _cvUserService: CvUserServiceService;
  userInfo: ICvUser = initICvUser;
  constructor(cvUserService: CvUserServiceService) {
    this._cvUserService = cvUserService;
   }

  ngOnInit() {
    this._cvUserService.getUserInfo().then(c => {
      let jsonData = c;

      this.userInfo = jsonData;
    });
  }

}
