import { Injectable } from '@angular/core';
import { getApiUrl } from './../../helpers/path-helper'

@Injectable()
export class UserimageServiceService {

  constructor() { }


  public get imagePath(): string {
    return getApiUrl('/userimages/MortenOttersenBW.jpg');
  }


}
