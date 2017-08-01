import { Component, OnInit, Input } from '@angular/core';
import { IEntries } from './../../interfaces/i-entires';
import { DateTimeService } from './../../services/helpers/date-time.service';

@Component({
  selector: 'app-view-cv-entry',
  templateUrl: './view-cv-entry.component.html',
  styleUrls: ['./view-cv-entry.component.css']
})
export class ViewCvEntryComponent implements OnInit {
  @Input() entry:IEntries
    constructor(private dateTimeService:DateTimeService ) { }

  ngOnInit() {
  }

}
