import { Component, OnInit } from '@angular/core';
import { CvUserServiceService } from './../services/cv-user-service/cv-user-service.service';
import { ICvUser, initICvUser } from './../interfaces/i-user';

@Component({
  selector: 'app-view-cv-user-header',
  templateUrl: './view-cv-user-header.component.html',
  styleUrls: ['./view-cv-user-header.component.css']
})
export class ViewCvUserHeaderComponent implements OnInit {

  _cvUserService: CvUserServiceService;
  _userInfo: ICvUser = initICvUser;
  constructor(cvUserService: CvUserServiceService) {
    this._cvUserService = cvUserService;
  }

  ngOnInit() {
    this._cvUserService.getUserInfo().subscribe(c => {
      let jsonData = c.json();
      
      this._userInfo = jsonData;
      console.log(this._userInfo);
    });
  }

}
