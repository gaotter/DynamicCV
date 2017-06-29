import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { ICvUser, initICvUser } from './../../interfaces/i-user';

@Injectable()
export class CvUserServiceService {

  constructor(private _http: Http) { }
  _userInfo: ICvUser;

  getUserInfo() {

    let userPromise = new Promise<ICvUser>((resolve, reject) => {
      if (this._userInfo) {
        resolve(this._userInfo);
      } else {
        this._http.get('/api/cvuser').subscribe(c => {
          let jsonData = c.json();

          this._userInfo = jsonData;

          resolve(this._userInfo);
        })
      }
    });
    return userPromise;
  }

}
