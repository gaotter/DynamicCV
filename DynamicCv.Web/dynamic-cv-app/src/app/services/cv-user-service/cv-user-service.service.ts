import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { ICvUser, initICvUser } from './../../interfaces/i-user';
import { Router, ActivatedRoute } from '@angular/router';

@Injectable()
export class CvUserServiceService {

  constructor(private _http: Http, private route: ActivatedRoute,
        private router: Router,) { }
  _userInfo: ICvUser;

  getUserInfo() {

    let userPromise = new Promise<ICvUser>((resolve, reject) => {
      if (this._userInfo) {
        resolve(this._userInfo);
      } else {
        this._http.get('/api/cvuser').subscribe(c => {
          let jsonData = c.json();

          this._userInfo = jsonData;
          console.log(this._userInfo);
          if(this._userInfo.loginStatus === "NotLoggedIn") {
            this.router.navigate(["login"]);
          }

          resolve(this._userInfo);
        })
      }
    });
    return userPromise;
  }

}
