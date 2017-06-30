import { Injectable } from '@angular/core';
import * as moment from 'moment';
import getLocalDateString from './../../helpers/date-format';

@Injectable()
export class DateTimeService {

  constructor() { }

  tickToLocalStr = (ticks:number) => moment(ticks).format(getLocalDateString());

}
