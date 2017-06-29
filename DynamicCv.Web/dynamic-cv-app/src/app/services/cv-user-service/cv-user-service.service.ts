import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class CvUserServiceService {

  constructor(private _http:Http) { }
  userInfo = {}

  getUserInfo() {
      
     return this._http.get('/api/cvuser');

      
  }

}
